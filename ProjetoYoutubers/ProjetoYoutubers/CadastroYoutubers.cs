using System;
using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoYoutubers
{
    public partial class CadastroYoutubers : Form
    {
        public int posicao = -1;
        public static string NOME_ARQUIVO = "Youtuber.bin";
        public CadastroYoutubers()
        {
            InitializeComponent();
        }


        private void CadastroYoutubers_Load(object sender, EventArgs e)
        {

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Youtuber youtuber = new Youtuber();
            youtuber.SetName(txtNome.Text);
            youtuber.SetLastname(txtSobrenome.Text);
            youtuber.SetNickname(txtApelido.Text);
            youtuber.SetChannel(txtNomeCanal.Text);
            youtuber.SetNumberViews(Convert.ToInt64(txtQuantVisual.Text));
            youtuber.SetNumberLikes(Convert.ToInt64(txtLikes.Text));
            youtuber.SetAds(rbAdsSim.Checked);
            youtuber.SetAds(rbAdsNão.Checked);
            youtuber.SetMoney(Convert.ToDouble(txtRenda.Text));
            youtuber.SetChannel(txtNomeCanal.Text);
            youtuber.SetLink(txtLink.Text);
            youtuber.SetNumberOfVideos(Convert.ToInt32(nupQuantVideos.Text));
            youtuber.SetNationality(cbNacionalidade.Text);
            youtuber.SetStreamer(rbStreamerSim.Checked);
            youtuber.SetStreamer(rbStreamerNão.Checked);
            youtuber.SetPlataforma(cbPlataforma.Text);

            YoutuberRepository tudo = new YoutuberRepository();
            tudo.AdicionarYoutuber(youtuber);

            MessageBox.Show("Youtuber Cadastrado com Sucesso");
            AtualizarListaYoutuber();
        }

        private void AtualizarListaYoutuber()
        {
            YoutuberRepository tudo = new YoutuberRepository();
            dataGridView1.Rows.Clear();
            foreach (Youtuber youtuber in tudo.ObterYoutubers())
            {
                dataGridView1.Rows.Add(new Object[] {
                    youtuber.GetName(),
                youtuber.GetLastname(),
                youtuber.GetNickname(),
                youtuber.GetChannel(),
                youtuber.GetNumberViews(),
                youtuber.GetNumberLikes(),
                youtuber.GetMoney(),
                youtuber.GetLink(),
                youtuber.GetNumberOfVideos(),
                youtuber.GetNationality(),
                youtuber.GetPlataforma()
            });


            }
        }

        private void CadastroYoutubers_Activated(object sender, EventArgs e)
        {
            AtualizarListaYoutuber();
        }

        private void ApagarYoutuber()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione algum Youtuber");
                return;
            }
            string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            YoutuberRepository repositorio = new YoutuberRepository();
            repositorio.ApagarYoutuber(name);
            MessageBox.Show(name + "Removido com Sucesso");
        }

        private void EditarYoutubers()
        {
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Selecione algo nesta lista");
                    return;
                }

                string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                YoutuberRepository repository = new YoutuberRepository();
                int quantidade = 0;
                foreach (Youtuber youtuber in repository.ObterYoutubers())
                {
                    if (youtuber.GetName() == name)
                    {
                        txtNome.Text = youtuber.GetName();
                        txtSobrenome.Text = youtuber.GetLastname();
                        txtApelido.Text = youtuber.GetNickname();
                        txtNomeCanal.Text = youtuber.GetChannel();
                        txtQuantVisual.Text = Convert.ToString(youtuber.GetNumberViews());
                        txtLikes.Text = Convert.ToString(youtuber.GetNumberLikes());
                        rbAdsSim.Text = Convert.ToString(youtuber.GetAds());
                        txtRenda.Text = Convert.ToString(youtuber.GetMoney());
                        txtLink.Text = youtuber.GetLink();
                        nupQuantVideos.Text = Convert.ToString(youtuber.GetNumberOfVideos());
                        cbNacionalidade.Text = youtuber.GetNationality();
                        rbStreamerSim.Checked = youtuber.GetStreamer();
                        cbPlataforma.Text = youtuber.GetNationality();
                        posicao = quantidade;
                        return;
                    }
                    quantidade++;
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarYoutubers();
            string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            YoutuberRepository repositorio = new YoutuberRepository();
            repositorio.ApagarYoutuber(name);
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ApagarYoutuber();
        }

       
    }
}
