using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Лабораторная_работа__1__Сортировки_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int MatrixSize = 1000;


        #region Выбор сортировки 
        int Sort = 1;
        String SortString = "сортировка выбором";
        private void SortChoice_CheckedChanged(object sender, EventArgs e)
        {
            Sort = 1;
            SortString = "сортировка выбором";
        }

        private void SortInsert_CheckedChanged(object sender, EventArgs e)
        {
            Sort = 2;
            SortString = "сортировка вставками";
        }

        private void SortExchange_CheckedChanged(object sender, EventArgs e)
        {
            Sort = 3;
            SortString = "сортировка обменом";
        }

        private void SortShella_CheckedChanged(object sender, EventArgs e)
        {
            Sort = 4;
            SortString = "сортировка Шелла";
        }

        private void SortFast_CheckedChanged(object sender, EventArgs e)
        {
            Sort = 5;
            SortString = "сортировка быстрая";
        }
        private void SortClassic_CheckedChanged(object sender, EventArgs e)
        {
            Sort = 6;
            SortString = "сортировка встроенная";
        }

        #endregion

        private void btnGo_Click(object sender, EventArgs e)
        {
            int[,] FirstMatrix = CreateMatrix();


            MessageBox.Show("Матрица сгенерирована, будет выполняться сортировка");

            Stopwatch timer=null;

            switch (Sort)
            {
                case 1:
                    timer = Stopwatch.StartNew();
                    ChoiceSort(FirstMatrix);
                    timer.Stop();
                    break;
                case 2:
                    timer = Stopwatch.StartNew();
                    InsertsSort(FirstMatrix);
                    timer.Stop();
                    break;
                case 3:
                    timer = Stopwatch.StartNew();
                    ExchangeSort(FirstMatrix);
                    timer.Stop();
                    break;
                case 4:
                    timer = Stopwatch.StartNew();
                    ShellaSort(FirstMatrix);
                    timer.Stop();
                    break;
                case 5:
                    timer = Stopwatch.StartNew();
                    for (int k = 0; k < MatrixSize; k++)
                    {
                        QuickSort(FirstMatrix, 0, MatrixSize- 1, k);
                    }                     
                    timer.Stop();
                    break;
                case 6:
                    timer = Stopwatch.StartNew();
                    for (int i = 0; i < MatrixSize; i++)
                    {
                        timer.Start();
                        int[] MyArray = new int[MatrixSize];
                        for (int j = 0; j < MatrixSize; j++)
                        {
                            MyArray[j]=FirstMatrix[i, j];
                        }                   
                        Array.Sort(MyArray);
                        timer.Stop();
                        for (int j = 0; j < MatrixSize; j++)
                        {
                            FirstMatrix[i,j]=MyArray[j];
                        }
                    }                 
                    break;
            }
            
            MessageBox.Show("Сортировка закончена, выполните сохранение");

            SaveMatrix(FirstMatrix, SortString, timer.ElapsedMilliseconds.ToString());
        }

        #region Генерация матрицы
        int[,] CreateMatrix()
        {
            int[,] Matrix = new int[MatrixSize, MatrixSize];
            Random rand = new Random();
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    Matrix[i, j] = rand.Next(0, 5001);
                }
            }
            return Matrix;
        }
        #endregion
        #region Сохранение



        public void SaveMatrix(int[,] Matrix2, String str, String timeSort)
        {
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = true;

            _Workbook workbook = excelapp.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = (_Worksheet)workbook.ActiveSheet;

            excelapp.UserControl = false;


            bool failed = false;
            do
            {
                try
                {
                    worksheet.Cells[1, 1] = "Отсортированнная  матрица. " + "Была применена " + str + ". Время выполнения сортировки = " + timeSort + " мс";
                    for (int i = 0; i < MatrixSize; i++)
                    {
                        for (int j = 0; j < MatrixSize; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = Matrix2[i, j];
                        }
                    }

                    workbook.Save();

                    failed = false;
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    failed = true;
                }
                System.Threading.Thread.Sleep(10);

            } while (failed);
        }
        #endregion
        #region Cортировки
        void ChoiceSort(int[,] ListForSort)
        {
            for (int k = 0; k < MatrixSize; k++)
            {
                int index = 0;

                for (int i = 0; i < MatrixSize - 1; i++)
                {
                    index = i;

                    for (int j = i + 1; j < MatrixSize; j++)
                    {
                        if (ListForSort[k, j].CompareTo(ListForSort[k, index]) == -1)
                        {
                            index = j;
                        }
                    }

                    if (index != i)
                    {
                        int temp = ListForSort[k, i];
                        ListForSort[k, i] = ListForSort[k, index];
                        ListForSort[k, index] = temp;
                    }
                }
            }
        }


        void InsertsSort(int[,] ListForSort)
        {

            for (int k = 0; k < MatrixSize; k++)
            {
                for (int i = 0; i < MatrixSize; i++)
                {
                    var temp = ListForSort[k, i];
                    var j = i;
                    while (j > 0 && temp.CompareTo(ListForSort[k, j - 1]) == -1)
                    {
                        ListForSort[k, j] = ListForSort[k, j - 1];
                        j--;
                    }
                    ListForSort[k, j] = temp;
                }

            }
        }

        void ExchangeSort(int[,] ListForSort)
        {

            for (int k = 0; k < MatrixSize; k++)
            {
                int count = MatrixSize;
                for (int j = 0; j < count; j++)
                {
                    for (int i = 0; i < count - 1 - j; i++)
                    {
                        var a = ListForSort[k, i];
                        var b = ListForSort[k, i + 1];
                        if (a.CompareTo(b) == 1)
                        {
                            int temp = ListForSort[k, i];
                            ListForSort[k, i] = ListForSort[k, i + 1];
                            ListForSort[k, i + 1] = temp;
                        }

                    }
                    count--;
                }

            }
        }

        void ShellaSort(int[,] ListForSort)
        {

            for (int k = 0; k < MatrixSize; k++)
            {
                int step = MatrixSize / 2;

                while (step > 0)
                {
                    for (int i = step; i < MatrixSize; i++)
                    {
                        int j = i;
                        while (j >= step && ListForSort[k, j - step].CompareTo(ListForSort[k, j]) == 1)
                        {
                            int temp = ListForSort[k, j - step];
                            ListForSort[k, j - step] = ListForSort[k, j];
                            ListForSort[k, j] = temp;
                            j -= step;
                        }
                    }
                    step /= 2;
                }
            }
        }

        void QuickSort(int[,] ListForSort, int left, int right, int k)
        {
            if (left >= right) { return; }
            else
            {
                var pivot = Sorting(ListForSort, left, right, k);
                QuickSort(ListForSort, left, pivot - 1, k);
                QuickSort(ListForSort, pivot + 1, right, k);
            }
        }

        int Sorting(int[,] ListForSort, int left, int right, int k)
        {
            var pointer = left;
            for (int i = left; i <= right; i++)
            {
                if (ListForSort[k, i].CompareTo(ListForSort[k, right]) == -1)
                {
                    int temp1 = ListForSort[k, i];
                    ListForSort[k, i] = ListForSort[k, pointer];
                    ListForSort[k, pointer] = temp1;
                    pointer++;
                }
            }

            int temp = ListForSort[k, right];
            ListForSort[k, right] = ListForSort[k, pointer];
            ListForSort[k, pointer] = temp;

            return pointer;
        }


        #endregion


    }
}
