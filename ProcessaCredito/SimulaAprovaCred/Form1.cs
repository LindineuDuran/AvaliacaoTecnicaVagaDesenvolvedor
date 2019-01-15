using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Credito;

namespace SimulaAprovaCred
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Double valCred = Convert.ToDouble(txtValCred.Text);

            String tipoCred = Convert.ToString(cboTipoCred.SelectedItem);
            String codPed ="";
            switch (tipoCred)
                {
                    case "Crédito Direto":
                        //Crédito Direto
                        codPed ="CD";

                        break;

                    case "Crédito Consignado":
                        //Crédito Consignado
                        codPed ="CC";

                        break;

                    case "Crédito Pessoa Jurídica":
                        //Crédito Pessoa Jurídica
                        codPed ="CPJ";

                        break;

                    case "Crédito Pessoa Física":
                        //Crédito Pessoa Física
                        codPed ="CPF";

                        break;

                    case "Crédito Imobiliário":
                        //Crédito Imobiliário
                        codPed ="CI";

                        break;
                }

            int numParc = Convert.ToInt16(txtNumParc.Text);

            String primVenc = dtPrimVenc.Text;

            Credit credito = new Credit(valCred, codPed, numParc, primVenc);

            txtValTotJur.Text = Convert.ToString(credito.ValComJuros);
            txtValJur.Text = Convert.ToString(credito.ValJuros);
            txtStatusCred.Text = credito.StatusCred;
        }
    }
}
