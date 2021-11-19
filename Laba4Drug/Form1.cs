using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Laba4Drug
{
    public partial class Form1 : Form
    {
        int[] startArray;
        Stopwatch swBubble = new Stopwatch();
        Stopwatch swInsert = new Stopwatch();
        Stopwatch swShake = new Stopwatch();
        Stopwatch swBogo = new Stopwatch();
        Stopwatch swQuick = new Stopwatch();

        Thread bubleThread;
        Thread insertThread;
        Thread shakeThread;
        Thread quickThread;
        Thread bogoThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateArray_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int m = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
            startArray = new int[m];
            for (int j = 0; j < m; j++)
            {
                dataGridView1.Rows.Add();
                startArray[j] = rnd.Next(1, 1000);
                dataGridView1[0, j].Value = startArray[j];
            }
        }
        //Bubble
        private void BubbleSort()
        {
           
            int[] newArray = new int[startArray.Length];
            startArray.CopyTo(newArray, 0);
            swBubble.Restart();
            swBubble.Start();
            for (int i = 1; i < newArray.Length; i++)
            {
                for (int j = 0; j < newArray.Length - 1; j++)
                {
                    if (DownToUp.Checked)
                    {
                        if (newArray[j + 1] < newArray[j])
                        {
                            int n = newArray[j];
                            newArray[j] = newArray[j + 1];
                            newArray[j + 1] = n;
                        }
                    }
                    else if (UpToDown.Checked)
                    {
                        if (newArray[j + 1] > newArray[j])
                        {
                            int n = newArray[j];
                            newArray[j] = newArray[j + 1];
                            newArray[j + 1] = n;
                        }
                        
                    }
                    ChartUpd(chart1, newArray);
                }
            }
            swBubble.Stop();
            Timers(bubbleTime, swBubble);
        }

        private void Swap(ref int value1, ref int value2)
        {
            int value3 = value1;
            value1 = value2;
            value2 = value3;
        }
        private int PivotIndex(int[] array, int minId, int maxId)
        {
            int index = minId - 1;
            for (int i = minId; i < maxId; i++)
            {
                if (DownToUp.Checked)
                {
                    if (array[i] < array[maxId])
                    {
                        index++;
                        Swap(ref array[index], ref array[i]);
                    }
                }
                else if (UpToDown.Checked)
                {
                    if (array[i] > array[maxId])
                    {
                        index++;
                        Swap(ref array[index], ref array[i]);
                    }
                }
                ChartUpd(chart5, array);

            }
            index++;
            Swap(ref array[index], ref array[maxId]);
            return index;
        }
        private int[] QuickSort(int[] array, int minId, int maxId)
        {
            if (minId >= maxId)
                return array;
            int pivotPoint = PivotIndex(array, minId, maxId);
            QuickSort(array, minId, pivotPoint - 1);
            QuickSort(array, pivotPoint + 1, maxId);
            return array;
        }
        public void QuickSort()
        {
            int[] newArray = new int[startArray.Length];
            startArray.CopyTo(newArray, 0);
            swQuick.Restart();
            swQuick.Start();
            newArray = QuickSort(newArray, 0, newArray.Length - 1);
            swQuick.Stop();
            Timers(quickTime, swQuick);
        }

        private void InsertionSort()
        {
            int[] newArray = new int[startArray.Length];
            startArray.CopyTo(newArray, 0);
            swInsert.Restart();
            swInsert.Start();
            if (DownToUp.Checked)
            {
                for (int i = 1; i < newArray.Length; i++)
                {
                    int key = newArray[i];
                    int j = i;
                    while ((j > 0) && (newArray[j - 1] > key))
                    {
                        Swap(ref newArray[j - 1], ref newArray[j]);
                        j--;
                    }
                    ChartUpd(chart2, newArray);
                    newArray[j] = key;
                }
            }
            else
            {
                for (int i = 1; i < newArray.Length; i++)
                {
                    int key = newArray[i];
                    int j = i;
                    while ((j > 0) && (newArray[j - 1] < key))
                    {
                        Swap(ref newArray[j - 1], ref newArray[j]);
                        j--;
                    }
                    ChartUpd(chart2, newArray);
                    newArray[j] = key;
                }
            }
            swInsert.Stop();
            Timers(insertTime, swInsert);
        }

        private void ShakerSort()
        {
            int[] newArray = new int[startArray.Length];
            startArray.CopyTo(newArray, 0);
            swShake.Restart();
            swShake.Start();
            for (int i = 0; i < newArray.Length / 2; i++)
            {
                bool swapFlag = false;
                //проход слева направо
                for (int j = i; j < newArray.Length - i - 1; j++)
                {
                    if (DownToUp.Checked)
                    {
                        if (newArray[j] > newArray[j + 1])
                        {
                            Swap(ref newArray[j], ref newArray[j + 1]);
                            swapFlag = true;
                        }
                    }
                    else
                    {
                        if (newArray[j] < newArray[j + 1])
                        {
                            Swap(ref newArray[j], ref newArray[j + 1]);
                            swapFlag = true;
                        }
                    }
                    ChartUpd(chart3, newArray);

                }
                //проход справа налево
                for (int j = newArray.Length - 2 - i; j > i; j--)
                {
                    if (DownToUp.Checked)
                    {
                        if (newArray[j - 1] > newArray[j])
                        {
                            Swap(ref newArray[j - 1], ref newArray[j]);
                            swapFlag = true;
                        }
                    }
                    else
                    {
                        if (newArray[j - 1] < newArray[j])
                        {
                            Swap(ref newArray[j - 1], ref newArray[j]);
                            swapFlag = true;
                        }
                    }
                    ChartUpd(chart3, newArray);
                }
                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }
            swShake.Stop();
            Timers(shakeTime, swShake);
        }
        static bool IsSorted(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                    return false;
            }
            return true;
        }
        static bool IsSorted1(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] < a[i + 1])
                    return false;
            }
            return true;
        }
        //перемешивание элементов массива
        private int[] RandomPermutation(int[] array)
        {
            int[] newArray = new int[array.Length];
            array.CopyTo(newArray, 0);
            Random random = new Random();
            var n = newArray.Length;
            while (n > 1)
            {
                n--;
                var i = random.Next(n + 1);
                var temp = newArray[i];
                newArray[i] = newArray[n];
                newArray[n] = temp;
            }
            return newArray;
        }
        //случайная сортировка
        private void BogoSort()
        {
            int[] newArray = new int[startArray.Length];
            startArray.CopyTo(newArray, 0);
            swBogo.Restart();
            swBogo.Start();
            if (DownToUp.Checked)
            {
                while (!IsSorted(newArray))
                {
                    newArray = RandomPermutation(newArray);
                    ChartUpd(chart4, newArray);
                }
            }
            else
            {
                while (!IsSorted1(newArray))
                {
                    newArray = RandomPermutation(newArray);
                    ChartUpd(chart4, newArray);
                }
            }
            swBogo.Stop();
            Timers(bogoTime, swBogo);
        }

        static object locker = new object();
        private void ChartUpd(System.Windows.Forms.DataVisualization.Charting.Chart chart, int[] Data)
        {
            try
            {
                lock (locker)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        chart.Series[0].Points.DataBindXY(null, Data);
                        chart.Update();
                    });
                }
            }
            catch { }
            
        }

        private void Timers(System.Windows.Forms.Label Seconds, Stopwatch stopwatch)
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    Seconds.Text = Math.Round((stopwatch.Elapsed.TotalSeconds), 2).ToString() + " sec.";
                });
            }
            catch { }
            
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (startArray != null)
            {
                if (bubbleBox.Checked == true)
                {
                    bubleThread = new Thread(new ThreadStart(BubbleSort));
                    bubleThread.Start();
                }
                if (insertBox.Checked == true)
                {
                    insertThread = new Thread(new ThreadStart(InsertionSort));
                    insertThread.Start();
                }
                if (shakeBox.Checked == true)
                {
                    shakeThread = new Thread(new ThreadStart(ShakerSort));
                    shakeThread.Start();
                }
                if (quickBox.Checked == true)
                {
                    quickThread = new Thread(new ThreadStart(QuickSort));
                    quickThread.Start();
                }
                if (bogoBox.Checked == true)
                {
                    bogoThread = new Thread(new ThreadStart(BogoSort));
                    bogoThread.Start();
                }
            }
                
            else
            {
                MessageBox.Show("Ошибка");
            }
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (bubbleBox.Checked)
            {
                bubleThread.Abort();
                Timers(bubbleTime, swBubble);
            }
            if (insertBox.Checked)
            {
                insertThread.Abort();
                Timers(insertTime, swInsert);
            }
            if (shakeBox.Checked)
            {
                shakeThread.Abort();
                Timers(shakeTime, swShake);
            }
            if (quickBox.Checked)
            {
                quickThread.Abort();
                Timers(quickTime, swQuick);
            }
            if (bogoBox.Checked == true)
            {
                bogoThread.Abort();
                Timers(bogoTime, swBogo);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
