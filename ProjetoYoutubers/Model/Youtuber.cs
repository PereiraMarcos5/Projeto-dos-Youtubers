using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Model
{
    [Serializable]
    public class Youtuber
    {
        private string Name;
        private string Lastname;
        private string Nickname;
        private string Channel;
        private long NumberViews;
        private long NumberLikes;
        private bool Ads;
        private double Money;
        private string Link;
        private int NumberOfVideos;
        private string Nationality;
        private string Plataforma;

        public void SetName(string nome)
        {
            if (nome.Trim().Count() < 3)
            {
                throw new Exception("Nome deve conter 3 letras");
            }

            if (nome.Trim().Count() > 40)
            {
                throw new Exception("Nome deve conter menos que 40 letras");
            }
            Name = nome;
        }

        public void SetLastname(string sobrenome)
        {
            if (sobrenome.Trim().Count() < 4)
            {
                throw new Exception("Sobrenome deve conter 4 letras");
            }
            if (sobrenome.Trim().Count() > 40)
            {
                throw new Exception("Sobrenome deve conter menos que 40 letras");
            }
            Lastname = sobrenome;
        }

        public void SetNickname(string apelido)
        {
            if (apelido.Trim().Count() < 2)
            {
                throw new Exception("Apelido deve conter mais que 2 caracteres");
            }

            if (apelido.Trim().Count() > 15)
            {
                throw new Exception("Apelido deve ter menos que 15 caracteres");
            }
            Nickname = apelido;
        }

        public void SetChannel(string canal)
        {
            if (canal.Trim().Count() < 4)
            {
                throw new Exception("Nome do Canal deve conter no minimo 4 caracteres");
            }
            if (canal.Trim().Count() > 12)
            {
                throw new Exception("Nome do Canal de conter no maximo 12 caracteres");
            }
            Channel = canal;
        }

        public void SetNumberViews(long views)
        {
            if (views <= 0)
            {
                throw new Exception("O canal não pode ter views negativos");
            }
            NumberViews = views;
        }

        public void SetNumberLikes(long likes)
        {
            if (likes <= 0)
            {
                throw new Exception("O canal não pode ter views negativos");
            }
            NumberLikes = likes;
        }

        public void SetAds(bool anuncio)
        {
            Ads = anuncio;
        }

        public void SetMoney(double renda)
        {
            if (renda < 0)
            {
                throw new Exception("A renda tem que ser maior que 0");
            }
            Money = renda;
        }

        public void SetLink(string link)
        {
            if (link.Count() > 24 /*não me entenda errado 24 é apenas o numero de caracteres que tem em https://www.youtube.com/ */)
            {
                throw new Exception("Deixe o Link correto de seu canal");
            }
            Link = link;
        }

        public void SetNumberOfVideos(int videos)
        {
            if (videos < 0)
            {
                throw new Exception("O número de videos tem que ser maior que 0");
            }

            if (videos > 200000)
            {
                throw new Exception("O numero de videos tem menor que 200000");
            }
            NumberOfVideos = videos;
        }

        private void SetNationality(string país)
        {
            Nationality = país;
        }

        private void SetPlataforma(string plataforma)
        {
            Plataforma = plataforma;
        }


        public void GetName()
        {
            return;
        }

    }
}
