using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace HighfieldTechTest
{
    public partial class Highfield : Form
    {
        internal static string Domain { get; } = "https://recruitment.highfieldqualifications.com/api";
        internal static string GET_ENDPOINT { get; } = "https://recruitment.highfieldqualifications.com/api/test";
        internal static string POST_ENDPOINT { get; } = "https://recruitment.highfieldqualifications.com/api/test";

        private static HttpClient client;

        private bool m_getDataPressed = false;
        private bool m_processDataPressed = false;

        private IEnumerable<UserEntity> m_data;
        private IEnumerable<AgePlusTwentyDTO> m_ages;
        private IEnumerable<TopColoursDTO> m_topColours;

        public Highfield()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(Domain)
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void ProcessData_Click(object sender, EventArgs e)
        {
            if (m_getDataPressed)
            {

                try
                {

                    m_ages = AgePlusTwentyDTO.ConvertData(m_data);
                    m_topColours = TopColoursDTO.ConvertData(m_data);


                    dgv_AgePlusTwentyTwo.DataSource = Common.ToDataTable(m_ages);
                    dgv_TopColours.DataSource = Common.ToDataTable(m_topColours);

                    Refresh();

                    m_processDataPressed = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Something went wrong with data Processing\n{0}", ex.Message));
                    m_processDataPressed = false;
                }
            }
            else
            {
                MessageBox.Show("We need data to process");
            }
        }

        private async void GetData_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                m_data = await UserEntity.GetDataAsync(client, GET_ENDPOINT);

                dgv_UserEntities.DataSource = Common.ToDataTable(m_data);

                m_getDataPressed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Something went wrong with request\n{0}", ex.Message));

                m_getDataPressed = false;
            }
        }

        private async void Btn_sendResponse_ClickAsync(object sender, EventArgs e)
        {

            if (m_processDataPressed)
            {
                try
                {
                    HttpResponseMessage response = await ResponseDTO.PostDataAsync(client, POST_ENDPOINT, 
                        new ResponseDTO { Users = m_data, Ages = m_ages, TopColours = m_topColours });

                    MessageBox.Show(response.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Something went wrong with response\n{0}", ex.Message));

                    m_getDataPressed = false;
                }
            }

            else
            {
                MessageBox.Show("Process Data first");
            }
        }
    }

}
