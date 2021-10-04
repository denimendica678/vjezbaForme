using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PonavljanjeFormi20211004
{
    public partial class Form2 : Form
    {
        List<Test> lista = new List<Test>();

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Test> listaTest)
        {
            lista = listaTest;
            InitializeComponent();
        }

    }
}
