using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private int Money;
        private string Link;
        private int NumberOfVideos;
        private string Nationality;

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

        public void setChannel(string canal)
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

        public void setNumberViews(long views)
        {
            if (views <= 0)
            {
                throw new Exception("O canal não pode ter views negativos");
            }
            NumberViews = views;
        }

        public void setNumberLikes(long likes)
        {
            if (likes <= 0)
            {
                throw new Exception("O canal não pode ter views negativos");
            }
            NumberLikes = likes;
        }

            public void setAds(bool anuncio)
        {
            Ads = anuncio;
        }

        public 


    }
}
