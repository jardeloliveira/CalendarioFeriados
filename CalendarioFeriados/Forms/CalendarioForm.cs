using CalendarioFeriados.Services;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalendarioFeriados.Forms
{
    public partial class CalendarioForm : MetroForm
    {
        public CalendarioForm()
        {
            InitializeComponent();
        }

        
        List<DateTime> datas = new List<DateTime>();
        private void CalendarioForm_Load(object sender, EventArgs e)
        {

        }

        private void calendario_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            
                if (datas.Contains(e.Start)) { MessageBox.Show("Feriado"); }
            
        }

        private void atualizarBtn_Click(object sender, EventArgs e)
        {
            //Seleciona o ano atual
            var ano = DateTime.Now.Year.ToString();

            if (!string.IsNullOrEmpty(codibge.Text))
            {
                var result = new ApiCaledarioService().ConsultaFeriadosAsync(codibge.Text, ano).Result;
                if (result != null)
                {

                    foreach (var item in result)
                    {
                        datas.Add(DateTime.Parse(item.date));
                    }
                    calendario.BoldedDates = datas.ToArray();
                }
                else
                {
                    MessageBox.Show("Código do Município não foi encontrado da base de dados. " +
                        "Favor verificar o código e tentar novamente.");
                }
            }
          
        }


    }
}
