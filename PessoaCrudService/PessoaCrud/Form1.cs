using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PessoaCrud
{
    public partial class Form1 : Form
    {
        private PessoaService.Service1SoapClient pessoaService = new PessoaService.Service1SoapClient();
        public Form1()
        {
            InitializeComponent();
            this.bindingSourcePessoa.AddNew();
            this.GetAllPessoas();
        }

        private void GetAllPessoas()
        {
            this.BindingSourcePessoaList.DataSource = this.pessoaService.GetAllPessoas();
            this.BindingSourcePessoaList.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pessoa = this.bindingSourcePessoa.Current as PessoaService.Pessoa;
            if (pessoa != null)
            {
                if (pessoa.Chave == 0)
                {
                    this.pessoaService.Inserir(pessoa);
                }
                else
                {
                    this.pessoaService.EditPessoa(pessoa);
                }
                this.GetAllPessoas();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pessoa = this.pessoaService.GetPessoaByKey(1);

            MessageBox.Show(String.Format("Nome: {0} \n\n Idade: {1}", pessoa.Nome, pessoa.Idade));
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(this.BindingSourcePessoaList.Count > 0)
            {
                this.bindingSourcePessoa.Clear();
                this.bindingSourcePessoa.Add(this.BindingSourcePessoaList.Current);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pessoa = this.BindingSourcePessoaList.Current as PessoaService.Pessoa;
            if (pessoa != null)
            {
                this.pessoaService.RemovePessoa(pessoa);
                this.bindingSourcePessoa.Clear();
                this.bindingSourcePessoa.AddNew();
                this.GetAllPessoas();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.bindingSourcePessoa.Clear();
            this.bindingSourcePessoa.AddNew();
        }
    }
}
