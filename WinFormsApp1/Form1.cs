using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string Username1 { get; set; }
        private string FileUName = "Usersfiles0101";
        public Form1()
        {
            InitializeComponent();
        }
        private void Userfile(string UserName)
        {
            using FileStream fs = new FileStream(FileUName + ".bin", FileMode.Append, FileAccess.Write);
            using BinaryWriter br = new BinaryWriter(fs);
            br.Write(UserName);
        }
        private bool JSONDeserializeMethod(string filename)
        {
            using FileStream fs = new FileStream(FileUName + ".bin", FileMode.Open, FileAccess.Read);
            using BinaryReader br = new BinaryReader(fs);
            for (int i = 0; i < fs.Length;)
            {
                string text = br.ReadString();
                i += text.Length+1;
                if (text==filename)return true;
            }
            return false;
        }
        private bool JSONDeserializeMethod2(string filename)
        {
            string[] Item = null;
            {
                var stringData = File.ReadAllText(filename + ".json");
                Item = JsonConvert.DeserializeObject<string[]>(stringData);
            }
            Name1.Text = Item[0]; surname.Text = Item[1]; Fname.Text = Item[2];
            Country.Text = Item[3]; city.Text = Item[4]; phone.Text = Item[5]; dateTimePicker1.Text = Item[6];
            if (Item[7] == "Male") radioButton1.Checked = true;
            else radioButton2.Checked = true;
            return true;
        }
        void JSONSerializeMethod()
         {

            string Gender = "Male";
            if (!radioButton1.Checked) Gender = "Famele";
            string[] array = new string[]
            {
                Name1.Text,surname.Text,Fname.Text,Country.Text,city.Text,phone.Text,dateTimePicker1.Text,Gender
            };
            Userfile(Name1.Text);
            {
                var jsonString = System.Text.Json.JsonSerializer.Serialize(array);
                File.WriteAllText(Username1 + ".json", jsonString);
            }


        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            string pattern = "^((\\+)|(994)|(\\*)|())[0-9]{3,14}((\\#)|())$";
            if (Name1.Text==""||surname.Text==""||Fname.Text==""||Country.Text==""||city.Text==""||phone.Text=="")Erro.Text = "Please fill all forms";
            else
            {
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(phone.Text))
                {
                    AZE.Text = "";
                    Erro.Text = "";
                    Username1 = Name1.Text;
                    MessageBox.Show(Username1);
                    JSONSerializeMethod();
                }
                else AZE.Text = "AZE number"; AZE.ForeColor = Color.Red;
            }
        }
        private void Load_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                if (JSONDeserializeMethod(textBox1.Text))
                {
                    MessageBox.Show("a");
                    JSONDeserializeMethod2(textBox1.Text);
                }

            }   
        }
    }
}