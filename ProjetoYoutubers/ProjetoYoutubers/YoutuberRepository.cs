using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ProjetoYoutubers
{
    [Serializable]
    class YoutuberRepository
    {
        public static string NOME_ARQUIVO = "Youtubers.bin";
        List<Youtuber> youtubers = new List<Youtuber>();

        public void AdicionarYoutuber(Youtuber youtuber)
        {
            youtubers.Add(youtuber);
            EscreverNoArquivoDosYoutubers();
        }

        public YoutuberRepository()
        {
            if (File.Exists(CadastroYoutubers.NOME_ARQUIVO))
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead(CadastroYoutubers.NOME_ARQUIVO);
                youtubers = ((YoutuberRepository)binaryReader.Deserialize(stream)).ObterYoutubers();
                stream.Close();
            }
        }

        private void EscreverNoArquivoDosYoutubers()
        {
            BinaryFormatter binaryWriter = new BinaryFormatter();
            Stream stream = new FileStream(CadastroYoutubers.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWriter.Serialize(stream, this);
            stream.Close();
        }

        public List<Youtuber> ObterYoutubers()
        {
            return youtubers;
        }


        internal void ApagarYoutuber(string name)
        {
            foreach (Youtuber youtuber in youtubers)
            {
                if (youtuber.GetName() == name)
                {
                    youtubers.Remove(youtuber);
                    EscreverNoArquivoDosYoutubers();
                    return;

                }
           }
        }

        internal void EditarYoutubers(Youtuber youtuber, int posicao)
        {
            youtubers[posicao] = youtuber;
            EscreverNoArquivoDosYoutubers();
        }
    }
}
