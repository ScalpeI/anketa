using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anketa.Form1lvl
{
    public partial class Form1app : Form
    {
        public Form1app()
        {
            InitializeComponent();
            this.Size = pQuestion.Size + new Size(40, 40);
            QuestBuild();
        }

        public int iQuest = 1, iPoint = 1;
        public string sAnswer, sPoint;
        public void QuestBuild()
        {
            if (iQuest == 1)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "1. Насколько Вы удовлетворены качеством бесплатной медицинской помощи, получаемой в поликлинике.";
                pQuestPoint.Visible = false;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            else if (iQuest == 2 & iPoint == 1)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "2.Оценили уровень удовлетворенности следующими характеристиками работы  поликлиники.";
                lQuestPoint.Text = "1.Техническим состоянием, ремонтом помещений";
                pQuestPoint.Visible = true;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            else if (iQuest == 2 & iPoint == 2)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "2.Оценили уровень удовлетворенности следующими характеристиками работы  поликлиники.";
                lQuestPoint.Text = "2. Оснащенностью современным медицинским оборудованием";
                pQuestPoint.Visible = true;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            else if (iQuest == 2 & iPoint == 3)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "2.Оценили уровень удовлетворенности следующими характеристиками работы  поликлиники.";
                lQuestPoint.Text = "3.  Организацией записи на прием к врачу";
                pQuestPoint.Visible = true;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            else if (iQuest == 2 & iPoint == 4)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "2.Оценили уровень удовлетворенности следующими характеристиками работы  поликлиники.";
                lQuestPoint.Text = "4. Временем ожидания приема врача";
                pQuestPoint.Visible = true;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            else if (iQuest == 2 & iPoint == 5)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "2.Оценили уровень удовлетворенности следующими характеристиками работы  поликлиники.";
                lQuestPoint.Text = "5. Сроками ожидания медицинских услуг после записи";
                pQuestPoint.Visible = true;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            else if (iQuest == 2 & iPoint == 6)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "2.Оценили уровень удовлетворенности следующими характеристиками работы  поликлиники.";
                lQuestPoint.Text = "6. Доступностью необходимых лабораторных исследований/анализов";
                pQuestPoint.Visible = true;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            else if (iQuest == 2 & iPoint == 7)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "2.Оценили уровень удовлетворенности следующими характеристиками работы  поликлиники.";
                lQuestPoint.Text = "7. Доступностью диагностичеких исследований (ЭКГ, УЗИ и т.д.)";
                pQuestPoint.Visible = true;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            else if (iQuest == 2 & iPoint == 8)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "2.Оценили уровень удовлетворенности следующими характеристиками работы  поликлиники.";
                lQuestPoint.Text = "8. Доступностью мед.помощи терапевтов";
                pQuestPoint.Visible = true;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            else if (iQuest == 2 & iPoint == 9)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "2.Оценили уровень удовлетворенности следующими характеристиками работы  поликлиники.";
                lQuestPoint.Text = "9.  Доступностью мед.помощи врачей-специалистов";
                pQuestPoint.Visible = true;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            else if (iQuest == 2 & iPoint == 10)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "2.Оценили уровень удовлетворенности следующими характеристиками работы  поликлиники.";
                lQuestPoint.Text = "10. Работой лечащего врача";
                pQuestPoint.Visible = true;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            if (iQuest == 3)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = false;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "3. Приходилось ли Вам лично за последние 3 месяца обращаться к услугам СМП.";
                pQuestPoint.Visible = false;
                rb1.Text = "1. Да";
                rb2.Text = "2. Нет";
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            if (iQuest == 4)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = true;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "4. Насколько Вы удовлетворены качеством оказанной Вам скорой медицинской помощи.";
                pQuestPoint.Visible = false;
                rb1.Text = "1. Удовлетворен (а)";
                rb2.Text = "2. Скорее удовлетворен (а), чем не удовлетворен (а)";
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            if (iQuest == 5)
            {
                pAnswer1.Visible = true;
                pAnswer2.Visible = false;
                pAnswer3.Visible = false;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "5. Ваш пол.";
                pQuestPoint.Visible = false;
                rb1.Text = "1. Мужской";
                rb2.Text = "2. Женский";
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                rb5.Visible = true;
            }
            if (iQuest == 6)
            {
                pAnswer1.Visible = false;
                pAnswer2.Visible = false;
                pAnswer3.Visible = true;
                pQuestion.Visible = true;
                pQuestion.Dock = DockStyle.Fill;
                pQuestText.Visible = true;
                lQuestText.Text = "6. Ваш возраст.";
                pQuestPoint.Visible = false;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                rb1.Visible = false;
                rb2.Visible = false;
                rb3.Visible = false;
                rb4.Visible = false;
                rb5.Visible = false;
            }

        }
        private void bQ1Ok_Click(object sender, EventArgs e)
        {
            if (rb1.Checked != false | rb2.Checked != false | rb3.Checked != false | rb4.Checked != false | rb5.Checked != false | tbAge.Text!="")
            {
                if (iQuest < 6)
                {
                    if (iQuest == 3 & rb2.Checked == true) {
                        iQuest += 2;
                        sAnswer += sPoint+";null;";
                        QuestBuild();
                    }
                    else if (iQuest != 2 | iPoint == 10)
                    {
                        iQuest += 1;
                        sAnswer += sPoint+";";
                        QuestBuild(); }
                    else if (iQuest == 2 & iPoint != 10)
                    {
                        iPoint += 1;
                        sAnswer += sPoint + ";";
                        QuestBuild();
                    }
                }
                else if (iQuest == 6)
                {
                    sAnswer += tbAge.Text;
                    AddForm(sAnswer);
                    this.Close();
                }
            }

            else
            {
                MessageBox.Show("Выберете ответ!");
            }
        }

        private static void AddForm(string value)
        {
            // название процедуры
            string sqlExpression = "CreateForm1app";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                string[] quest = value.Split(new char[] { ';' });

                SqlParameter Q1Param = new SqlParameter
                {
                    ParameterName = "@Q1",
                    Value = quest[0]
                };
                // добавляем параметр
                command.Parameters.Add(Q1Param);
                SqlParameter Q21Param = new SqlParameter
                {
                    ParameterName = "@Q21",
                    Value = quest[1]
                };
                // добавляем параметр
                command.Parameters.Add(Q21Param);
                SqlParameter Q22Param = new SqlParameter
                {
                    ParameterName = "@Q22",
                    Value = quest[2]
                };
                // добавляем параметр
                command.Parameters.Add(Q22Param);
                SqlParameter Q23Param = new SqlParameter
                {
                    ParameterName = "@Q23",
                    Value = quest[3]
                };
                // добавляем параметр
                command.Parameters.Add(Q23Param);
                SqlParameter Q24Param = new SqlParameter
                {
                    ParameterName = "@Q24",
                    Value = quest[4]
                };
                // добавляем параметр
                command.Parameters.Add(Q24Param);
                SqlParameter Q25Param = new SqlParameter
                {
                    ParameterName = "@Q25",
                    Value = quest[5]
                };
                // добавляем параметр
                command.Parameters.Add(Q25Param);
                SqlParameter Q26Param = new SqlParameter
                {
                    ParameterName = "@Q26",
                    Value = quest[6]
                };
                // добавляем параметр
                command.Parameters.Add(Q26Param);
                SqlParameter Q27Param = new SqlParameter
                {
                    ParameterName = "@Q27",
                    Value = quest[7]
                };
                // добавляем параметр
                command.Parameters.Add(Q27Param);
                SqlParameter Q28Param = new SqlParameter
                {
                    ParameterName = "@Q28",
                    Value = quest[8]
                };
                // добавляем параметр
                command.Parameters.Add(Q28Param);
                SqlParameter Q29Param = new SqlParameter
                {
                    ParameterName = "@Q29",
                    Value = quest[9]
                };
                // добавляем параметр
                command.Parameters.Add(Q29Param);
                SqlParameter Q210Param = new SqlParameter
                {
                    ParameterName = "@Q210",
                    Value = quest[10]
                };
                // добавляем параметр
                command.Parameters.Add(Q210Param);
                SqlParameter Q3Param = new SqlParameter
                {
                    ParameterName = "@Q3",
                    Value = quest[11]
                };
                // добавляем параметр
                command.Parameters.Add(Q3Param);
                SqlParameter Q4Param = new SqlParameter
                {
                    ParameterName = "@Q4",
                    Value = quest[12]
                };
                // добавляем параметр
                command.Parameters.Add(Q4Param);
                SqlParameter Q5Param = new SqlParameter
                {
                    ParameterName = "@Q5",
                    Value = quest[13]
                };
                // добавляем параметр
                command.Parameters.Add(Q5Param);
                SqlParameter Q6Param = new SqlParameter
                {
                    ParameterName = "@Q6",
                    Value = quest[14]
                };
                // добавляем параметр
                command.Parameters.Add(Q6Param);

                var result = command.ExecuteScalar();
                // если нам не надо возвращать id
                //var result = command.ExecuteNonQuery();

                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
        }

        private void rb1Q1_Click(object sender, EventArgs e)
        {
            rb1.Checked = true;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
            rb5.Checked = false;
            sPoint = "1";
           
        }

        private void rb2Q1_Click(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = true;
            rb3.Checked = false;
            rb4.Checked = false;
            rb5.Checked = false;
            sPoint = "2";
        }

        private void rb3Q1_Click(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = true;
            rb4.Checked = false;
            rb5.Checked = false;
            sPoint = "3";
        }

        private void rb4Q1_Click(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = true;
            rb5.Checked = false;
            sPoint = "4";
        }

        private void rb5Q1_Click(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
            rb5.Checked = true;
            sPoint = "99";
        }
    }
}
