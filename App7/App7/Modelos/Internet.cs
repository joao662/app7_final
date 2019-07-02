using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    class Internet : Contato
    {

        // atributo email
        private String email;

        public String Email
        {

            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }

        }

        // atributo site
        private String site;

        public String Site
        {

            get
            {
                return this.site;
            }

            set
            {
                this.site = value;
            }

        }

        // construtor da classe
        public Internet(String email, String site)
        {
            this.email = email;
            this.site = site;
        }

        public List<string> Comunicar()
        {
            return new List<String>() {
                "Enviar email para " + this.email,
                "Entrar no site " + this.site
            };
        }
    }
}
