﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.IO;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            information info    = new information();
            info.serverName     = serverNameBox.Text;
            info.databaseName   = databaseNameComboBox.Text;
            info.DBUserName     = DBuserNameBox.Text;
            info.DBPassword     = DBpasswordBOX.Password;

            saveXML.saveData(info,"data.xml");
            MessageBox.Show("Save Successfully !");
        }
    }
}
