using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PessoaCrudService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        #region STATIC ATRIBUTES.
        private static Int32 key = 0;
        private static Dictionary<Int32, PessoaDll.Pessoa> pessoas = new Dictionary<Int32, PessoaDll.Pessoa>();
        #endregion

        #region METHODS.
        [WebMethod]
        public void Inserir(PessoaDll.Pessoa pessoa)
        {
            pessoa.Chave = ++key;
            pessoas.Add(pessoa.Chave, pessoa);
        }

        [WebMethod]
        public PessoaDll.Pessoa GetPessoaByKey(Int32 Key)
        {
            PessoaDll.Pessoa pessoa = null;
            pessoas.TryGetValue(key, out pessoa);
            return pessoa;
        }

        [WebMethod]
        public List<PessoaDll.Pessoa> GetAllPessoas()
        {
            return pessoas.Values.ToList();
        }

        
        [WebMethod]
        public void RemovePessoa(PessoaDll.Pessoa pessoa)
        {
            pessoas.Remove(pessoa.Chave);
        }

        [WebMethod]
        public void EditPessoa(PessoaDll.Pessoa pessoa)
        {
            pessoas[pessoa.Chave] = pessoa;
        }
        #endregion
    }
}