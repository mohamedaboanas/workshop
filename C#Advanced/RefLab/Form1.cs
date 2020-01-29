using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Windows.Forms.VisualStyles;
using Reflactor;

namespace RefLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_get_class_Click(object sender, EventArgs e)
        {
            if (open_file_select.ShowDialog() == DialogResult.OK)
            {
                txt_file_path.Text = open_file_select.FileName;
                Assembly assembly = Assembly.LoadFile(txt_file_path.Text);

                var modules = assembly.GetModules()[0];
                var types = modules.GetTypes();

                foreach (var type in types)
                {
                    var attributes = Attribute.GetCustomAttributes(type, typeof(RoleAttribute));
                    foreach (var attribute in attributes)
                    {
                        RoleAttribute role = (RoleAttribute)attribute;
                        if (role.Roles == "Admin")
                        {
                            list_Classes.Items.Add(type.Name);

                        }
                    }
                }

            }

        }
        private void btn_get_methods_Click(object sender, EventArgs e)
        {

        }
        private void list_Classes_Click(object sender, EventArgs e)
        {
            list_methods.Items.Clear();
            txt_file_path.Text = open_file_select.FileName;
            Assembly assembly = Assembly.LoadFile(txt_file_path.Text);

            foreach (Type type in assembly.GetTypes())
            {
                if (type.Name == list_Classes.SelectedItem.ToString())
                {
                    if (type.IsClass)
                    {
                        var attributes = Attribute.GetCustomAttributes(type, typeof(RoleAttribute));
                        foreach (var attribute in attributes)
                        {
                            RoleAttribute role = (RoleAttribute)attribute;
                            if (role.Roles == "Admin")
                            {
                                MethodInfo[] methods = type.GetMethods();
                                foreach (var method in methods)
                                {
                                    list_methods.Items.Add(method.Name);

                                }

                            }
                        }
                    }

                }

            }
        }
        private void list_Classes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}