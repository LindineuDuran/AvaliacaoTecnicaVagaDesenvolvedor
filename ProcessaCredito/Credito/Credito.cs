using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Credito
{
    public class Credit
    {
        //Valor do Crédito
        private Double _valCred;
        public Double ValCred
        {
            get { return _valCred; }
            set { _valCred = value; }
        }

        //Tipo do Crédito
        private String _tipoCred;
        public String TipoCred
        {
            get { return _tipoCred; }
            set { _tipoCred = value; }
        }

        //Número de Parcelas
        private int _numParc;
        public int NumParc
        {
            get { return _numParc; }
            set { _numParc = value; }
        }

        //Data do Primeiro Vencimento
        private String _primVenc;
        public String PrimVenc
        {
            get { return _primVenc; }
            set { _primVenc = value; }
        }

        //Status do Crédito
        private String _statusCred;
        public String StatusCred
        {
            get { return _statusCred; }
            set { _statusCred = value; }
        }

        //Valor Total com Juros
        private Double _valComJuros = 0;
        public Double ValComJuros
        {
            get { return _valComJuros; }
            set { _valComJuros = value; }
        }

        //Valor dos Juros Mensais
        private Double _valJuros = 0;
        public Double ValJuros
        {
            get { return _valJuros; }
            set { _valJuros = value; }
        }

        public Credit(Double valCred, String tipoCred, int numParc, String primVenc)
        {
            bool statValCred = false;
            if (valCred <= 1000000)
            {
                statValCred = true;
                _valCred = valCred;
            }

            bool statNumParc = false;
            if (numParc >=5 && numParc <= 72)
            {
                statNumParc = true;
                _numParc = numParc;
            }

            bool statPrimVenc = false;
            DateTime today = DateTime.Today;
            if (CheckDate(primVenc) && Convert.ToDateTime(primVenc) >= today.AddDays(15) && Convert.ToDateTime(primVenc) <= today.AddDays(40))
            {
                statPrimVenc = true;
                _primVenc = primVenc;
            }

            if (statValCred && statNumParc && statPrimVenc)
            {
                switch (tipoCred)
                {
                    case "CD":
                        //Crédito Direto
                        CredDiret credDiret = new CredDiret(valCred, numParc, primVenc);
                        credDiret.verifCredit();
                        _statusCred = credDiret.StatusCred;
                        _valComJuros = credDiret.ValComJuros;
                        _valJuros = credDiret.ValJuros;

                        break;

                    case "CC":
                        //Crédito Consignado
                        CredConsig credConsig = new CredConsig(valCred, numParc, primVenc);
                        credConsig.verifCredit();
                        _statusCred = credConsig.StatusCred;
                        _valComJuros = credConsig.ValComJuros;
                        _valJuros = credConsig.ValJuros;

                        break;

                    case "CPJ":
                        //Crédito Pessoa Jurídica
                        CredPessJurid credPessJurid = new CredPessJurid(valCred, numParc, primVenc);
                        credPessJurid.verifCredit();
                        _statusCred = credPessJurid.StatusCred;
                        _valComJuros = credPessJurid.ValComJuros;
                        _valJuros = credPessJurid.ValJuros;

                        break;

                    case "CPF":
                        //Crédito Pessoa Física
                        CredPessFis credPessFis = new CredPessFis(valCred, numParc, primVenc);
                        credPessFis.verifCredit();
                        _statusCred = credPessFis.StatusCred;
                        _valComJuros = credPessFis.ValComJuros;
                        _valJuros = credPessFis.ValJuros;

                        break;

                    case "CI":
                        //Crédito Imobiliário
                        CredImob credImob = new CredImob(valCred, numParc, primVenc);
                        credImob.verifCredit();
                        _statusCred = credImob.StatusCred;
                        _valComJuros = credImob.ValComJuros;
                        _valJuros = credImob.ValJuros;

                        break;
                }
            }
            else
            {
                _statusCred = "REPROVADO";
            }
        }

        private CredDiret CredDiret()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Verifica se é uma data válida
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        protected bool CheckDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    /// <summary>
    /// Crédito Genérico
    /// </summary>
    class CredGenerico
    {
        //Valor do Crédito
        protected Double _valCred;
        public Double ValCred
        {
            get { return _valCred; }
            set { _valCred = value; }
        }

        //Tipo do Crédito
        protected String _tipoCred;
        public String TipoCred
        {
            get { return _tipoCred; }
            set { _tipoCred = value; }
        }

        //Número de Parcelas
        protected int _numParc;
        public int NumParc
        {
            get { return _numParc; }
            set { _numParc = value; }
        }

        //Data do Primeiro Vencimento
        protected String _primVenc;
        public String PrimVenc
        {
            get { return _primVenc; }
            set { _primVenc = value; }
        }

        //Status do Crédito
        protected String _statusCred;
        public String StatusCred
        {
            get { return _statusCred; }
            set { _statusCred = value; }
        }

        //Valor Total com Juros
        protected Double _valComJuros = 0;
        public Double ValComJuros
        {
            get { return _valComJuros; }
            set { _valComJuros = value; }
        }

        //Valor dos Juros Mensais
        protected Double _valJuros = 0;
        public Double ValJuros
        {
            get { return _valJuros; }
            set { _valJuros = value; }
        }

        public CredGenerico(Double valCred, int numParc, String primVenc)
        {
            this._valCred = valCred;
            this._numParc = numParc;
            this._primVenc = primVenc;
        }

        /// <summary>
        /// Verifica Crédito
        /// </summary>
        /// <returns></returns>
        public virtual void verifCredit()
        {
            
        }
    }

    /// <summary>
    /// Crédito Direto
    /// </summary>
    class CredDiret : CredGenerico
    {
        public CredDiret(Double valCred, int numParc, String primVenc) : base(valCred, numParc, primVenc){}

        /// <summary>
        /// Verifica Crédito
        /// </summary>
        /// <returns></returns>
        public override void verifCredit()
        {
            _valJuros = 0.02;

            if (_valCred + ((_valCred * _valJuros * _numParc) / 100) <= 1000000)
            {
                _statusCred = "APROVADO";
                _valComJuros = _valCred + ((_valCred * _valJuros * _numParc) / 100);
            }
            else
            {
                _statusCred = "REPROVADO";
            }
        }
    }

    /// <summary>
    /// Crédito Consignado
    /// </summary>
    class CredConsig : CredGenerico
    {
        public CredConsig(Double valCred, int numParc, String primVenc) : base(valCred, numParc, primVenc){}

        /// <summary>
        /// Verifica Crédito
        /// </summary>
        /// <returns></returns>
        public override void verifCredit()
        {
            _valJuros = 0.01;

            if (_valCred + ((_valCred * _valJuros * _numParc) / 100) <= 1000000)
            {
                _statusCred = "APROVADO";
                _valComJuros = _valCred + ((_valCred * _valJuros * _numParc) / 100);
            }
            else
            {
                _statusCred = "REPROVADO";
            }
        }
    }

    /// <summary>
    /// Crédito Pessoa Jurídica
    /// </summary>
    class CredPessJurid : CredGenerico
    {
        public CredPessJurid(Double valCred, int numParc, String primVenc) : base(valCred, numParc, primVenc) { }

        /// <summary>
        /// Verifica Crédito
        /// </summary>
        /// <returns></returns>
        public override void verifCredit()
        {
            _valJuros = 0.05;

            if (_valCred + ((_valCred * _valJuros * _numParc) / 100) > 1000000 || _valCred + ((_valCred * _valJuros * _numParc) / 100) < 15000)
            {
                _statusCred = "REPROVADO";
            }
            else
            {
                _statusCred = "APROVADO";
                _valComJuros = _valCred + ((_valCred * _valJuros * _numParc) / 100);
            }
        }
    }

    /// <summary>
    /// Crédito Consignado
    /// </summary>
    class CredPessFis : CredGenerico
    {
        public CredPessFis(Double valCred, int numParc, String primVenc) : base(valCred, numParc, primVenc) { }

        /// <summary>
        /// Verifica Crédito
        /// </summary>
        /// <returns></returns>
        public override void verifCredit()
        {
            _valJuros = 0.03;

            if (_valCred + ((_valCred * _valJuros * _numParc) / 100) <= 1000000)
            {
                _statusCred = "APROVADO";
                _valComJuros = _valCred + ((_valCred * _valJuros * _numParc) / 100);
            }
            else
            {
                _statusCred = "REPROVADO";
            }
        }
    }

    /// <summary>
    /// Crédito Imobiliário
    /// </summary>
    class CredImob : CredGenerico
    {
        public CredImob(Double valCred, int numParc, String primVenc) : base(valCred, numParc, primVenc) { }

        /// <summary>
        /// Verifica Crédito
        /// </summary>
        /// <returns></returns>
        public override void verifCredit()
        {
            Double valJurosAno = 0.09;
            _valJuros = valJurosAno/12;

            if (_valCred + ((_valCred * _valJuros * _numParc) / 100) <= 1000000)
            {
                _statusCred = "APROVADO";
                _valComJuros = _valCred + ((_valCred * _valJuros * _numParc) / 100);
            }
            else
            {
                _statusCred = "REPROVADO";
            }
        }
    }
}
