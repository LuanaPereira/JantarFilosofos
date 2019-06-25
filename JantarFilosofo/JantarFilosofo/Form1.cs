using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JantarFilosofo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random sorteio = new Random();
        private static Semaphore Semaforo;
        Thread F1, F2, F3, F4, F5;
        Garfos[] Garfo = new Garfos[5];
        Filosofos[] Filosofo = new Filosofos[5];
        private bool ControleThread = true;
        private int Controlatempo = 3;
        private int ContadorFilosofo1 = 0;
        private int ContadorFilosofo2 = 0;
        private int ContadorFilosofo3 = 0;
        private int ContadorFilosofo4 = 0;
        private int ContadorFilosofo5 = 0;

        private void ListaTela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Semaforo = new Semaphore(2, 2);
            F1 = new Thread(Filosofo1);
            F2 = new Thread(Filosofo2);
            F3 = new Thread(Filosofo3);
            F4 = new Thread(Filosofo4);
            F5 = new Thread(Filosofo5);

            F1.IsBackground = false;
            F2.IsBackground = false;
            F3.IsBackground = false;
            F4.IsBackground = false;
            F5.IsBackground = false;

            for(int i=0; i<5; i++)
            {
                Garfo[i] = new Garfos();

                Filosofo[i] = new Filosofos();
                Filosofo[i].Nome = "Filosofo " + (i + 1).ToString();
                
            }

        }
        private void IniciarBotao(object sender, EventArgs e)
        {
            Contador1.Text = "0";
            Contador2.Text = "0";
            Contador3.Text = "0";
            Contador4.Text = "0";
            Contador5.Text = "0";

            for (int i=0; i<Garfo.Count(); i++)
            {
                Garfo[i].EmUso = false;
                Filosofo[i].Pensando = false;
            }

            ControleThread = true;

            F1.Abort();
            F2.Abort();
            F3.Abort();
            F4.Abort();
            F5.Abort();

            { F1 = new Thread(Filosofo1); F1.Start(); }
            { F3 = new Thread(Filosofo3); F3.Start(); }
            { F5 = new Thread(Filosofo5); F5.Start(); }
            { F2 = new Thread(Filosofo2); F2.Start(); }
            { F4 = new Thread(Filosofo4); F4.Start(); }


            iniciar.Enabled = false;
            Finalizar.Enabled = true;

        }
        private void Finalizar_Click(object sender, EventArgs e)
        {

        }

        private void Filosofo1()
        {
            while (ControleThread)
            {
                if (Garfo[4].EmUso == true || Garfo[0].EmUso == true)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        ListaTela.Items.Add(Filosofo[0].Nome + " está pensando");
                        Status1.Text = "Pensando";

                    });
                    Thread.Sleep(2000);
                }
                else
                {
                    int tempo = sorteio.Next(3000, 6000);
                    int TempoComendo = tempo / Controlatempo;
                    Semaforo.WaitOne();
                    {
                        Filosofo[0].Pensando = false;
                        Garfo[0].EmUso = true;
                        Garfo[4].EmUso = true;
                       
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            ListaTela.Items.Add(Filosofo[0].Nome + " está  comendo");
                            Status1.Text = "Comendo";
                            ContadorFilosofo1++;
                           
                            Contador1.Text = ContadorFilosofo1.ToString();
                        });
                      

                        Thread.Sleep(TempoComendo);
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            ListaTela.Items.Add(Filosofo[0].Nome + " está  pensando");
                            Status1.Text = "Pensando";
                        });
                       

                        Filosofo[0].Pensando = true;
                        Garfo[0].EmUso = false;
                        Garfo[4].EmUso = false;
                      

                    }
                    Semaforo.Release();
                    if (ContadorFilosofo1 == 5)
                    {
                        F1.Abort();
                        return;
                    }
                }
            }
        }
        private void Filosofo2()
        {
            int tempo = sorteio.Next(3000, 6000);
            int TempoComendo = tempo / Controlatempo;
            while (ControleThread)
            {
                if (Garfo[0].EmUso == true || Garfo[1].EmUso == true)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        ListaTela.Items.Add(Filosofo[1].Nome + " está pensando");
                        Status2.Text = "Pensando";
                    });
                    
                    Thread.Sleep(2000);
                }
                else
                {
                    Semaforo.WaitOne();
                    {
                        Filosofo[1].Pensando = false;
                        Garfo[0].EmUso = true;
                        Garfo[1].EmUso = true;

                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            ListaTela.Items.Add(Filosofo[1].Nome + " está  comendo");
                            Status2.Text = "Comendo";
                            ContadorFilosofo2++;
                          
                            Contador2.Text = ContadorFilosofo2.ToString();

                        });
                       

                        Thread.Sleep(TempoComendo);

                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            ListaTela.Items.Add(Filosofo[1].Nome + " está  pensando");
                            Status2.Text = "Pensando";
                        });
                       

                        Filosofo[1].Pensando = true;
                        Garfo[0].EmUso = false;
                        Garfo[1].EmUso = false;
                       
                    }
                    Semaforo.Release();
                    if (ContadorFilosofo2 == 5)
                    {
                        F2.Abort();
                        return;
                    }
                }
            }
        }
        private void Filosofo3()
        {
            int tempo = sorteio.Next(3000, 6000);
            int TempoComendo = tempo / Controlatempo;
            while (ControleThread)
            {
                if (Garfo[1].EmUso == true || Garfo[2].EmUso == true)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        ListaTela.Items.Add(Filosofo[2].Nome + " está pensando");
                        Status3.Text = "Pensando";
                    });
                   
                    Thread.Sleep(2000);
                }
                else
                {
                    Semaforo.WaitOne();
                    {
                        Filosofo[0].Pensando = false;
                        Garfo[0].EmUso = true;
                        Garfo[4].EmUso = true;

                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            ListaTela.Items.Add(Filosofo[2].Nome + " está  comendo");
                            Status3.Text = "Comendo";
                            ContadorFilosofo3++;
                            
                            Contador3.Text = ContadorFilosofo3.ToString();
                        });
                       

                        Thread.Sleep(TempoComendo);

                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            ListaTela.Items.Add(Filosofo[2].Nome + " está  pensando");
                            Status3.Text = "Pensando";
                        });
                      

                        Filosofo[2].Pensando = true;
                        Garfo[1].EmUso = false;
                        Garfo[2].EmUso = false;
                        
                    }
                    Semaforo.Release();
                    if (ContadorFilosofo3 == 5)
                    {
                        F3.Abort();
                        return;
                    }
                }
            }
        }
        private void Filosofo4()
        {
            int tempo = sorteio.Next(3000, 6000);
            int TempoComendo = tempo / Controlatempo;
            while (ControleThread)
            {
                if (Garfo[2].EmUso == true || Garfo[3].EmUso == true)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        ListaTela.Items.Add(Filosofo[3].Nome + " está pensando");
                        Status4.Text = "Pensando";
                    });
                    
                    Thread.Sleep(2000);
                }
                else
                {
                    Semaforo.WaitOne();
                    {
                        Filosofo[3].Pensando = false;
                        Garfo[2].EmUso = true;
                        Garfo[3].EmUso = true;
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            ListaTela.Items.Add(Filosofo[3].Nome + " está  comendo");
                            Status4.Text = "Comendo";
                            ContadorFilosofo4++;
                           
                            Contador4.Text = ContadorFilosofo4.ToString();
                        });
                       
                        Thread.Sleep(TempoComendo);
                        
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            ListaTela.Items.Add(Filosofo[3].Nome + " está  pensando");
                            Status4.Text = "Pensando";
                        });
                        Filosofo[3].Pensando = true;
                        Garfo[2].EmUso = false;
                        Garfo[3].EmUso = false;
                       
                    }
                    Semaforo.Release();
                    if (ContadorFilosofo4 == 5)
                    {
                        F4.Abort();
                        return;
                    }
                }
            }
        }
        private void Filosofo5()
        {
            int tempo = sorteio.Next(3000, 6000);
            int TempoComendo = tempo / Controlatempo;
            while (ControleThread)
            {
                if (Garfo[3].EmUso == true || Garfo[4].EmUso == true)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        ListaTela.Items.Add(Filosofo[4].Nome + " está pensando");
                        Status5.Text = "Pensando";
                    });
                    
                    Thread.Sleep(2000);
                }
                else
                {
                    Semaforo.WaitOne();
                    {
                        Filosofo[4].Pensando = false;
                        Garfo[3].EmUso = true;
                        Garfo[4].EmUso = true;

                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            ListaTela.Items.Add(Filosofo[4].Nome + " está  comendo");
                            Status5.Text = "Comendo";
                            ContadorFilosofo5++;
                          
                            Contador5.Text = ContadorFilosofo5.ToString();

                        });
                      

                        Thread.Sleep(TempoComendo);

                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            ListaTela.Items.Add(Filosofo[4].Nome + " está  pensando");
                            Status5.Text = "Pensando";
                        });
                       
                        Filosofo[4].Pensando = true;
                        Garfo[3].EmUso = false;
                        Garfo[4].EmUso = false;
                       
                    }
                    Semaforo.Release();
                    if (ContadorFilosofo5 == 5)
                    {
                        F5.Abort();
                        return;
                    }
                }
            }
        }
  
    }
}
