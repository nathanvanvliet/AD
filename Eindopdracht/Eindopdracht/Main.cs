﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindopdracht
{
    public partial class Main : Form
    {
        // arraylist
        MyArrayList<string> stringArray = new MyArrayList<string>();

        // search 
        int[] searchIntArray = new int[] { 3, 5, 7, 2, 3, 4, 7, 3, 4, 5, 2 };
        string[] searchStringArray = new string[] { "a", "g", "d", "c", "t", "h", "s", "d" };
        int searchInput;
        string stringInput;

        // queue  
        _Queue<string> stringQueue = new _Queue<string>();
        _PriorityQueue<string> pQueue = new _PriorityQueue<string>();

        // stack
        _Stack<string> stringStack = new _Stack<string>();

        // sort
        private long time_bubble = long.MaxValue, time_selection = long.MaxValue, time_insertion = long.MaxValue;

        // binary search tree
        BinarySearchTree<string> stringTree = new BinarySearchTree<string>();

        //Lists 
        _LinkedList<string> linkList = new _LinkedList<string>();
        _DoublyLinkedList<string> dLinkList = new _DoublyLinkedList<string>();
        _CirculairLinkedList<string> cLinkList = new _CirculairLinkedList<string>();

        // iterator 
        ListIter<string> iterator;
        _LinkedList<string> iterList = new _LinkedList<string>();

        public Main()
        {
            //set the priority of the program to the highest
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.RealTime;
            InitializeComponent();
            fillIterList();
        }
 

        // Form actions for ArrayList
        #region Arraylist
        private void addButton_Click(object sender, EventArgs e)
        {
            stringArray.Add(inputBox.Text);
            inputBox.Clear();
            refresh();
        }



        private void refresh()
        {
            arrayBox.Items.Clear();
            int n = stringArray.Count();
            for (int i = 0; i < n; i++)
            {
                var a = stringArray.getIndex(i);
                if (a != null)
                {
                    arrayBox.Items.Add(a);
                }

            }
        }

        private void addRangeButton_Click(object sender, EventArgs e)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("jumped");
            myQueue.Enqueue("over");
            myQueue.Enqueue("the");
            myQueue.Enqueue("lazy");
            myQueue.Enqueue("dog");

            stringArray.addRange(myQueue);

            refresh();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string s = inputBox.Text;
            stringArray.remove(s);
            inputBox.Clear();
            refresh();
        }

        private void inArrayButton_Click(object sender, EventArgs e)
        {
            string s = searchBox.Text;
            bool b = stringArray.contains(s);
            searchBox.Clear();
            inArrayLabel.Text = b.ToString();
        }

        private void indexButton_Click(object sender, EventArgs e)
        {
            string s = searchBox.Text;
            int i = stringArray.indexOf(s);
            searchBox.Clear();
            indexLabel.Text = i.ToString();
        }

        private void capacityButton_Click(object sender, EventArgs e)
        {
            capacityLabel.Text = stringArray.Capacity().ToString();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            stringArray.clear();
            refresh();
        }

        private void removeAtButton_Click(object sender, EventArgs e)
        {
            if(indexBox.Text != "")
            {
                int index = int.Parse(indexBox.Text);
                stringArray.removeAt(index);
                refresh();
            }
        }
        #endregion

        // form actions for search 
        #region Search

        private void intFirstOcc_Click(object sender, EventArgs e)
        {
            try
            {
                searchInput = int.Parse(intInputBox.Text);
                intResultLabel.Text = Search<int>.firstSeqSearch(searchIntArray, searchInput).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void intLastOcc_Click(object sender, EventArgs e)
        {
            try
            {
                searchInput = int.Parse(intInputBox.Text);
                intResultLabel.Text = Search<int>.lastSeqSearch(searchIntArray, searchInput).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void intCustOcc_Click(object sender, EventArgs e)
        {
            try
            {
                searchInput = int.Parse(intInputBox.Text);
                int occ = int.Parse(intOccBox.Text);
                intResultLabel.Text = Search<int>.occuranceSeqSearch(searchIntArray, searchInput, occ).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void intMin_Click(object sender, EventArgs e)
        {
            try
            {
                intResultLabel.Text = Search<int>.FindMin(searchIntArray).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void intMax_Click(object sender, EventArgs e)
        {
            try
            {
                intResultLabel.Text = Search<int>.FindMax(searchIntArray).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void intbinary_Click(object sender, EventArgs e)
        {
            try
            {
                searchInput = int.Parse(intInputBox.Text);
                int[] temp = searchIntArray;
                Array.Sort(temp);
                intResultLabel.Text = Search<int>.binarySearch(temp, searchInput).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void stringFirstOcc_Click(object sender, EventArgs e)
        {
            stringInput = (string)stringBox.Text;
            stringResultLabel.Text = Search<string>.firstSeqSearch(searchStringArray, stringInput).ToString();
        }

        private void stringLastOcc_Click(object sender, EventArgs e)
        {
            stringInput = stringBox.Text;
            stringResultLabel.Text = Search<string>.lastSeqSearch(searchStringArray, stringInput).ToString();
        }

        private void stringCustOcc_Click(object sender, EventArgs e)
        {
            try
            {
                stringInput = stringBox.Text;
                int occ = int.Parse(stringOccBox.Text);
                stringResultLabel.Text = Search<string>.occuranceSeqSearch(searchStringArray, stringInput, occ).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void stringMin_Click(object sender, EventArgs e)
        {
            stringResultLabel.Text = Search<string>.FindMin(searchStringArray).ToString();
        }

        private void stringMax_Click(object sender, EventArgs e)
        {
            stringResultLabel.Text = Search<string>.FindMax(searchStringArray).ToString();
        }

        private void stringBinarySearch_Click(object sender, EventArgs e)
        {
            stringInput = stringBox.Text;
            string[] temp = searchStringArray;
            Array.Sort(temp);
            stringResultLabel.Text = Search<string>.binarySearch(temp, stringInput).ToString();
        }


        private void compareButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Searching for the number 213 in a ordered list with 1000 items.");
            int[] test = new int[1000];

            for (int i = 0; i < 999; i++)
            {
                test[i] = i;
            }
            TimeModule watch = new TimeModule();
            watch.start();
            int pos = Search<int>.firstSeqSearch(test, 213);
            watch.stop();
            Console.WriteLine("sequential search took {0} ticks", watch.elapseTime());
            Console.WriteLine("Sequential pos " + pos);

            TimeModule watch2 = new TimeModule();
            watch2.start();
            pos = Search<int>.binarySearch(test, 213);
            watch2.stop();
            Console.WriteLine("binary search took {0} ticks", watch2.elapseTime());
            Console.WriteLine("binary pos " + pos);
        }

        #endregion

        // form actions for queue
        #region Queue

        private void enqueueButt_Click(object sender, EventArgs e)
        {
            stringQueue.EnQueue(queuebox.Text);
            queuebox.Clear();
            refreshQueue();
        }

        private void refreshQueue()
        {
            queueList.Items.Clear();
            int n = stringQueue.Count();
            for (int i = 0; i < n; i++)
            {
                var a = stringQueue.getIndex(i);
                if (a != null)
                {
                    queueList.Items.Add(a);
                }

            }
        }

        private void dequeueButt_Click(object sender, EventArgs e)
        {
            stringQueue.deQueue();
            refreshQueue();
        }

        private void peekButt_Click(object sender, EventArgs e)
        {
            peekLabel.Text = stringQueue.Peek();
        }

        private void clearButt_Click(object sender, EventArgs e)
        {
            stringQueue.clear();
            refreshQueue();
        }

        private void countButt_Click(object sender, EventArgs e)
        {
            countLabel.Text = stringQueue.Count().ToString();
        }

        private void pEnqueue_Click(object sender, EventArgs e)
        {
            pQueue.EnQueue(pInput.Text, int.Parse(pPriority.Value.ToString()));
            pInput.Clear();
            pPriority.Value = 1;
            refreshPQueue();
        }

        private void refreshPQueue()
        {
            pQueueList.Items.Clear();
            int n = pQueue.Count();
            for (int i = 0; i < n; i++)
            {
                var a = pQueue.getIndex(i);
                if (a != null)
                {
                    pQueueList.Items.Add(a);
                }

            }
        }

        private void pDequeue_Click(object sender, EventArgs e)
        {
            pQueue.deQueue();
            refreshPQueue();
        }

        private void pPeek_Click(object sender, EventArgs e)
        {
            pPeekLabel.Text = pQueue.Peek();
        }

        private void pClear_Click(object sender, EventArgs e)
        {
            pQueue.clear();
            refreshPQueue();
        }

        private void pCount_Click(object sender, EventArgs e)
        {
            pCountLabel.Text = pQueue.Count().ToString();
        }
        #endregion

        // form actions for stack 
        #region Stack
        private void stackPush_Click(object sender, EventArgs e)
        {
            stringStack.push(stackInput.Text);
            stackInput.Clear();
            refreshStack();
        }

        private void refreshStack()
        {
            stackList.Items.Clear();
            int n = stringStack.getLength();
            for (int i = 0; i < n; i++)
            {
                var a = stringStack.getIndex(i);
                if (a != null)
                {
                    stackList.Items.Add(a);
                }

            }
        }

        private void stackPop_Click(object sender, EventArgs e)
        {
            stringStack.pop();
            refreshStack();
        }

        private void stackPeek_Click(object sender, EventArgs e)
        {
            sPeekLabel.Text = stringStack.Peek();
        }

        private void stackClear_Click(object sender, EventArgs e)
        {
            stringStack.clear();
            refreshStack();
        }

        private void stackCount_Click(object sender, EventArgs e)
        {
            sCountLabel.Text = stringStack.getLength().ToString();
        }
        #endregion

        // form actions for sort

        // select sort
        #region Selection sort
        private void selectSortString_Click(object sender, EventArgs e)
        {
            clearSortLists();
            //Array of 100 strings
            String[] array = new String[] { "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "upthrow", "blabber", "tokodynamometer", "poleaxe", "semisatirical", "liverwort", "commination", "materiel", "chanc", "previsitor", "carthusian", "roe", "heathenism", "thiocyanogen", "polonese", "madrigalist", "singultuses", "vendible", "brecknock", "struve", "quits", "porphyrogenite", "videvdat", "immigrational", "rapidity", "geoisotherm", "atamasco", "flatbread", "getter", "macintosh", "augmented", "egadi", "androspore", "heterochromatin", "sphericity", "kreutzer", "nonvirulent", "touchingness", "ectene", "boyhood" };
            //start the selection sorter
            try
            {
                //copy of the array to sort
                String[] tempArray = array;
                int n = tempArray.Length;
                for (int i = 0; i < n; i++)
                {
                    selectUnsortBox.Items.Add(tempArray[i]);
                }

                //start the sorting
                ArrayList temp = _Sort.Selection(tempArray);

                timeLabelSelect.Text = temp[0].ToString();
                String[] sorted = (string[])temp[1];

                int m = sorted.Length;
                for (int i = 0; i < m; i++)
                {
                    selectSortBox.Items.Add(sorted[i]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearSortLists();
        }

        private void selectReverse_Click(object sender, EventArgs e)
        {
            clearSortLists();
            //Array of 100 strings
            String[] array = new String[] { "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "upthrow", "blabber", "tokodynamometer", "poleaxe", "semisatirical", "liverwort", "commination", "materiel", "chanc", "previsitor", "carthusian", "roe", "heathenism", "thiocyanogen", "polonese", "madrigalist", "singultuses", "vendible", "brecknock", "struve", "quits", "porphyrogenite", "videvdat", "immigrational", "rapidity", "geoisotherm", "atamasco", "flatbread", "getter", "macintosh", "augmented", "egadi", "androspore", "heterochromatin", "sphericity", "kreutzer", "nonvirulent", "touchingness", "ectene", "boyhood" };
            _Sort.Insertion(array);
            Array.Reverse(array);

            //start the selection sorter
            try
            {
                //copy of the array to sort
                String[] tempArray = array;
                int n = tempArray.Length;
                for (int i = 0; i < n; i++)
                {
                    selectUnsortBox.Items.Add(tempArray[i]);
                }

                //start the sorting
                ArrayList temp = _Sort.Selection(tempArray);

                timeLabelSelect.Text = temp[0].ToString();
                String[] sorted = (string[])temp[1];

                int m = sorted.Length;
                for (int i = 0; i < m; i++)
                {
                    selectSortBox.Items.Add(sorted[i]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void selectSortInt_Click(object sender, EventArgs e)
        {
            clearSortLists();
            //create an array of ints
            int[] numbers = new int[1000];
            //fill the array
            int temp = 0;
            Random rnd = new Random();

            int max = numbers.Length;
            while (temp < max)
            {
                numbers[temp] = rnd.Next(1, 5000);
                temp++;
            }

            //start the selection sorter
            try
            {
                //copy of the array to sort
                int[] tempArray = numbers;
                int n = tempArray.Length;
                for (int i = 0; i < n; i++)
                {
                    selectUnsortBox.Items.Add(tempArray[i]);
                }

                //start the sorting
                ArrayList tempp = _Sort.Selection(tempArray);

                timeLabelSelect.Text = tempp[0].ToString();
                int[] sorted = (int[])tempp[1];

                int m = sorted.Length;
                for (int i = 0; i < m; i++)
                {
                    selectSortBox.Items.Add(sorted[i]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        // bubble sort
        #region Bubble sort
        private void bubbleClear_Click(object sender, EventArgs e)
        {
            clearSortLists();
        }



        private void bubbleArray_Click(object sender, EventArgs e)
        {
            clearSortLists();
            //Array of 100 strings
            String[] array = new String[] { "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "upthrow", "blabber", "tokodynamometer", "poleaxe", "semisatirical", "liverwort", "commination", "materiel", "chanc", "previsitor", "carthusian", "roe", "heathenism", "thiocyanogen", "polonese", "madrigalist", "singultuses", "vendible", "brecknock", "struve", "quits", "porphyrogenite", "videvdat", "immigrational", "rapidity", "geoisotherm", "atamasco", "flatbread", "getter", "macintosh", "augmented", "egadi", "androspore", "heterochromatin", "sphericity", "kreutzer", "nonvirulent", "touchingness", "ectene", "boyhood" };
            //start the Bubble sorter
            try
            {
                //copy of the array to sort
                String[] tempArray = array;
                int n = tempArray.Length;
                for (int i = 0; i < n; i++)
                {
                    bubbleUnsort.Items.Add(tempArray[i]);
                }

                //start the sorting
                ArrayList temp = _Sort.Bubble(tempArray);

                bubbleTimeLabel.Text = temp[0].ToString();
                String[] sorted = (string[])temp[1];

                int m = sorted.Length;
                for (int i = 0; i < m; i++)
                {
                    bubbleSorted.Items.Add(sorted[i]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bubbleReverse_Click(object sender, EventArgs e)
        {
            clearSortLists();
            //Array of 100 strings
            String[] array = new String[] { "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "upthrow", "blabber", "tokodynamometer", "poleaxe", "semisatirical", "liverwort", "commination", "materiel", "chanc", "previsitor", "carthusian", "roe", "heathenism", "thiocyanogen", "polonese", "madrigalist", "singultuses", "vendible", "brecknock", "struve", "quits", "porphyrogenite", "videvdat", "immigrational", "rapidity", "geoisotherm", "atamasco", "flatbread", "getter", "macintosh", "augmented", "egadi", "androspore", "heterochromatin", "sphericity", "kreutzer", "nonvirulent", "touchingness", "ectene", "boyhood" };
            _Sort.Insertion(array);
            Array.Reverse(array);

            //start the Bubble sorter
            try
            {
                //copy of the array to sort
                String[] tempArray = array;
                int n = tempArray.Length;
                for (int i = 0; i < n; i++)
                {
                    bubbleUnsort.Items.Add(tempArray[i]);
                }

                //start the sorting
                ArrayList temp = _Sort.Bubble(tempArray);

                bubbleTimeLabel.Text = temp[0].ToString();
                String[] sorted = (string[])temp[1];

                int m = sorted.Length;
                for (int i = 0; i < m; i++)
                {
                    bubbleSorted.Items.Add(sorted[i]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bubbleInt_Click(object sender, EventArgs e)
        {
            clearSortLists();
            //create an array of ints
            int[] array = new int[1000];
            //fill the array
            int temp = 0;
            Random rnd = new Random();

            int max = array.Length;
            while (temp < max)
            {
                array[temp] = rnd.Next(1, 5000);
                temp++;
            }

            //start the Bubble sorter
            try
            {
                //copy of the array to sort
                int[] tempArray = array;
                int n = tempArray.Length;
                for (int i = 0; i < n; i++)
                {
                    bubbleUnsort.Items.Add(tempArray[i]);
                }

                //start the sorting
                ArrayList tempp = _Sort.Bubble(tempArray);

                bubbleTimeLabel.Text = tempp[0].ToString();
                int[] sorted = (int[])tempp[1];

                int m = sorted.Length;
                for (int i = 0; i < m; i++)
                {
                    bubbleSorted.Items.Add(sorted[i]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        // insertion sort
        #region Insertion sort
        private void insertClear_Click(object sender, EventArgs e)
        {
            clearSortLists();
        }


        private void insertString_Click(object sender, EventArgs e)
        {
            clearSortLists();
            //Array of 100 strings
            String[] array = new String[] { "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "upthrow", "blabber", "tokodynamometer", "poleaxe", "semisatirical", "liverwort", "commination", "materiel", "chanc", "previsitor", "carthusian", "roe", "heathenism", "thiocyanogen", "polonese", "madrigalist", "singultuses", "vendible", "brecknock", "struve", "quits", "porphyrogenite", "videvdat", "immigrational", "rapidity", "geoisotherm", "atamasco", "flatbread", "getter", "macintosh", "augmented", "egadi", "androspore", "heterochromatin", "sphericity", "kreutzer", "nonvirulent", "touchingness", "ectene", "boyhood" };
            //start the insertion sorter
            try
            {
                //copy of the array to sort
                String[] tempArray = array;
                int n = tempArray.Length;
                for (int i = 0; i < n; i++)
                {
                    insertUnsort.Items.Add(tempArray[i]);
                }

                //start the sorting
                ArrayList temp = _Sort.Insertion(tempArray);

                insertTimeLabel.Text = temp[0].ToString();
                String[] sorted = (string[])temp[1];

                int m = sorted.Length;
                for (int i = 0; i < m; i++)
                {
                    insertSorted.Items.Add(sorted[i]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void insertReverse_Click(object sender, EventArgs e)
        {
            clearSortLists();
            //Array of 100 strings
            String[] array = new String[] { "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "upthrow", "blabber", "tokodynamometer", "poleaxe", "semisatirical", "liverwort", "commination", "materiel", "chanc", "previsitor", "carthusian", "roe", "heathenism", "thiocyanogen", "polonese", "madrigalist", "singultuses", "vendible", "brecknock", "struve", "quits", "porphyrogenite", "videvdat", "immigrational", "rapidity", "geoisotherm", "atamasco", "flatbread", "getter", "macintosh", "augmented", "egadi", "androspore", "heterochromatin", "sphericity", "kreutzer", "nonvirulent", "touchingness", "ectene", "boyhood" };
            _Sort.Insertion(array);
            Array.Reverse(array);

            //start the insertion sorter
            try
            {
                //copy of the array to sort
                String[] tempArray = array;
                int n = tempArray.Length;
                for (int i = 0; i < n; i++)
                {
                    insertUnsort.Items.Add(tempArray[i]);
                }

                //start the sorting
                ArrayList temp = _Sort.Insertion(tempArray);

                insertTimeLabel.Text = temp[0].ToString();
                String[] sorted = (string[])temp[1];

                int m = sorted.Length;
                for (int i = 0; i < m; i++)
                {
                    insertSorted.Items.Add(sorted[i]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void insertInt_Click(object sender, EventArgs e)
        {
            clearSortLists();
            //create an array of ints
            int[] array = new int[1000];
            //fill the array
            int temp = 0;
            Random rnd = new Random();

            int max = array.Length;
            while (temp < max)
            {
                array[temp] = rnd.Next(1, 5000);
                temp++;
            }

            //start the insertion sorter
            try
            {
                //copy of the array to sort
                int[] tempArray = array;
                int n = tempArray.Length;
                for (int i = 0; i < n; i++)
                {
                    insertUnsort.Items.Add(tempArray[i]);
                }

                //start the sorting
                ArrayList tempp = _Sort.Insertion(tempArray);

                insertTimeLabel.Text = tempp[0].ToString();
                int[] sorted = (int[])tempp[1];

                int m = sorted.Length;
                for (int i = 0; i < m; i++)
                {
                    insertSorted.Items.Add(sorted[i]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void clearSortLists()
        {
            bubbleUnsort.Items.Clear();
            bubbleSorted.Items.Clear();
            bubbleTimeLabel.Text = " ";
            selectUnsortBox.Items.Clear();
            selectSortBox.Items.Clear();
            timeLabelSelect.Text = " ";
            insertSorted.Items.Clear();
            insertUnsort.Items.Clear();
            insertTimeLabel.Text = " ";
        }



        #endregion

        // compare sort methods
        #region Compare sort methods
        private void sortReverse_Click(object sender, EventArgs e)
        {
            time_bubble = long.MaxValue;
            time_insertion = long.MaxValue;
            time_selection = long.MaxValue;
            //Array of 100 strings
            String[] array = new String[] { "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "upthrow", "blabber", "tokodynamometer", "poleaxe", "semisatirical", "liverwort", "commination", "materiel", "chanc", "previsitor", "carthusian", "roe", "heathenism", "thiocyanogen", "polonese", "madrigalist", "singultuses", "vendible", "brecknock", "struve", "quits", "porphyrogenite", "videvdat", "immigrational", "rapidity", "geoisotherm", "atamasco", "flatbread", "getter", "macintosh", "augmented", "egadi", "androspore", "heterochromatin", "sphericity", "kreutzer", "nonvirulent", "touchingness", "ectene", "boyhood" };
            _Sort.Insertion(array);
            Array.Reverse(array);



            //set the counter to 0 and check if the numberfield is a int. if not set it to 1
            int executionCount = 0, requiredExecutions = (Convert.ToInt32(execCount.Value) > 0) ? Convert.ToInt32(execCount.Value) : 1;

            //execute fr the times given by the user
            while (executionCount != requiredExecutions)
            {
                //start the Bubble sorter
                try
                {
                    //copy the array
                    String[] tempArray = array;

                    //start the sorting
                    ArrayList a = _Sort.Bubble(tempArray);
                    long temp = (long)a[0];
                    time_bubble = (temp < time_bubble) ? temp : time_bubble; //if the new value is smaller as the old, save the new value
                }
                catch (Exception)
                {
                    throw;
                }

                //start the selection sorter
                try
                {
                    //copy the array
                    String[] tempArray = array;

                    //start the sorting
                    ArrayList a = _Sort.Selection(tempArray);
                    long temp = (long)a[0];
                    time_selection = (temp < time_selection) ? temp : time_selection; //if the new value is smaller as the old, save the new value
                }
                catch (Exception)
                {
                    throw;
                }

                //start the insertion sorter
                try
                {
                    //copy the array
                    String[] tempArray = array;

                    //start the sorting
                    ArrayList a = _Sort.Insertion(tempArray);
                    long temp = (long)a[0];
                    time_insertion = (temp < time_insertion) ? temp : time_insertion; //if the new value is smaller as the old, save the new value
                }
                catch (Exception)
                {
                    throw;
                }

                executionCount++;
            }
            //Compare times and decalre a winner
            callWinner();
        }

        private void sortInt_Click(object sender, EventArgs e)
        {
            time_bubble = long.MaxValue;
            time_insertion = long.MaxValue;
            time_selection = long.MaxValue;
            //create an array of ints
            int[] numbers = new int[1000];
            //fill the array
            int temp = 0;
            Random rnd = new Random();

            int max = numbers.Length;
            while (temp < max)
            {
                numbers[temp] = rnd.Next(1, 5000);
                temp++;
            }

            //set the counter to 0 and check if the numberfield is a int. if not set it to 1
            int executionCount = 0, requiredExecutions = (Convert.ToInt32(execCount.Value) > 0) ? Convert.ToInt32(execCount.Value) : 1;

            //execute fr the times given by the user
            while (executionCount != requiredExecutions)
            {

                //start the Bubble sorter
                try
                {
                    // copy of the int array.
                    int[] array = numbers;
                    ArrayList a = _Sort.Bubble(array);
                    time_bubble = (long)a[0];
                }
                catch (Exception)
                {
                    throw;
                }

                //start the selection sorter
                try
                {
                    // copy of the int array.
                    int[] array = numbers;
                    ArrayList a = _Sort.Selection(array);
                    time_selection = (long)a[0];
                }
                catch (Exception)
                {
                    throw;
                }

                //start the insertion sorter
                try
                {
                    // copy of the int array.
                    int[] array = numbers;
                    ArrayList a = _Sort.Insertion(array);
                    time_insertion = (long)a[0];
                }
                catch (Exception)
                {
                    throw;
                }
                executionCount++;
            }
            //Compare times and decalre a winner
            callWinner();
        }

       

        private void sortString_Click(object sender, EventArgs e)
        {
            time_bubble = long.MaxValue;
            time_insertion = long.MaxValue;
            time_selection = long.MaxValue;
            //set the counter to 0 and check if the numberfield is a int. if not set it to 1
            int executionCount = 0, requiredExecutions = (Convert.ToInt32(execCount.Value) > 0) ? Convert.ToInt32(execCount.Value) : 1;

            //Array of 100 strings
            String[] array = new String[] { "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "condensed", "szombathely", "outthrusting", "tragion", "academe", "bighorns", "extravehicular", "dialectic", "hemiscotosis", "dolorimetric", "presupervised", "protrude", "overspiced", "chirography", "toltec", "broteas", "extensity", "soprano", "outsit", "proctor", "unresuscitative", "underring", "doodlesack", "multiplicand", "linearize", "superlikelihood", "parasitically", "bedrid", "predominate", "anadromous", "upthrow", "blabber", "tokodynamometer", "poleaxe", "semisatirical", "liverwort", "commination", "materiel", "chanc", "previsitor", "carthusian", "roe", "heathenism", "thiocyanogen", "polonese", "madrigalist", "singultuses", "vendible", "brecknock", "struve", "quits", "porphyrogenite", "videvdat", "immigrational", "rapidity", "geoisotherm", "atamasco", "flatbread", "getter", "macintosh", "augmented", "egadi", "androspore", "heterochromatin", "sphericity", "kreutzer", "nonvirulent", "touchingness", "ectene", "boyhood" };

            //execute fr the times given by the user
            while (executionCount != requiredExecutions)
            {
                //start the Bubble sorter
                try
                {
                    //copy of the array to sort
                    String[] tempArray = array;

                    //start the sorting
                    ArrayList a = _Sort.Bubble(tempArray);
                    long temp = (long)a[0];
                    time_bubble = (temp < time_bubble) ? temp : time_bubble; //if the new value is smaller as the old, save the new value
                }
                catch (Exception)
                {
                    throw;
                }

                //start the selection sorter
                try
                {
                    //copy of the array to sort
                    String[] tempArray = array;

                    //start the sorting
                    ArrayList a = _Sort.Selection(tempArray);
                    long temp = (long)a[0];
                    time_selection = (temp < time_selection) ? temp : time_selection; //if the new value is smaller as the old, save the new value
                }
                catch (Exception)
                {
                    throw;
                }

                //start the insertion sorter
                try
                {
                    //copy of the array to sort
                    String[] tempArray = array;

                    //start the sorting
                    ArrayList a = _Sort.Insertion(tempArray);
                    long temp = (long)a[0];
                    time_insertion = (temp < time_insertion) ? temp : time_insertion; //if the new value is smaller as the old, save the new value
                }
                catch (Exception)
                {
                    throw;
                }

                executionCount++;
            }

            //Compare times and decalre a winner
            callWinner();
        }


        private void callWinner()
        {
            String Winner = null;
            if (time_bubble < time_selection)
            {
                if (time_bubble < time_insertion)
                {
                    Winner = "Bubble Sort";
                }
                else
                {
                    Winner = "Insertion Sort";
                }
            }
            else
            {
                if (time_selection < time_insertion)
                {
                    Winner = "Selection Sort";
                }
                else
                {
                    Winner = "Insertion Sort";
                }
            }

            selectTickLabel.Text = time_selection.ToString();
            bubbleTickLabel.Text = time_bubble.ToString();
            insertionTickLabel.Text = time_insertion.ToString();
        }

        private void treeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        // form actions for binary search tree
        #region BinarySearchTree
        private void Insert_Click(object sender, EventArgs e)
        {
            string a = treeInput.Text;
            if (a != "")
            {
                stringTree.Insert(a);
                refreshTree();
                treeInput.Clear();
            }
        }

        private void Min_Click(object sender, EventArgs e)
        {
            treeMinLabel.Text = stringTree.findMin();
        }

        private void max_Click(object sender, EventArgs e)
        {
            treeMaxLabel.Text = stringTree.findMax();
        }


        private void delButton_Click(object sender, EventArgs e)
        {
            string a = treeInput.Text;
            if (a != "")
            {
                stringTree.delete(a);
                refreshTree();
                treeInput.Clear();
            }
        }

        private void leftNode_Click(object sender, EventArgs e)
        {
            if(treeBox.SelectedItem != null)
            {
                string temp = treeBox.SelectedItem.ToString();
                TreeNode<string> selected = stringTree.find(temp);
                if (selected != null && selected.left != null)
                {
                    string left = selected.left.data;
                    treeBox.SelectedItem = left;
                }
            }
           
        }


        private void rangeButton_Click(object sender, EventArgs e)
        {
         
            stringTree.Insert("a");
            stringTree.Insert("d");
            stringTree.Insert("v");
            stringTree.Insert("q");
            stringTree.Insert("b");
            stringTree.Insert("z");
            stringTree.Insert("j");
            stringTree.Insert("k");
            stringTree.Insert("m");
            stringTree.Insert("e");
            stringTree.Insert("f");
            stringTree.Insert("g");
            refreshTree();
        }

        private void rightNode_Click(object sender, EventArgs e)
        {
            if(treeBox.SelectedItem != null)
            {
                string temp = treeBox.SelectedItem.ToString();
                TreeNode<string> selected = stringTree.find(temp);
                if (selected != null && selected.right != null)
                {
                    string right = selected.right.data;
                    treeBox.SelectedItem = right;
                }
            }
        }


        private void inButton_Click(object sender, EventArgs e)
        {
            orderedTreeBox.Items.Clear();
            stringTree.clearList();
            TreeNode<string> root = stringTree.returnRoot();
            stringTree.inOrder(root);
            List<TreeNode<string>> list = stringTree.getList();
            foreach (TreeNode<string> node in list)
            {
                orderedTreeBox.Items.Add(node.data);
            }
        }

        private void preButton_Click(object sender, EventArgs e)
        {
            orderedTreeBox.Items.Clear();
            stringTree.clearList();
            TreeNode<string> root = stringTree.returnRoot();
            stringTree.preOrder(root);
            List<TreeNode<string>> list = stringTree.getList();
            foreach (TreeNode<string> node in list)
            {
                orderedTreeBox.Items.Add(node.data);
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            orderedTreeBox.Items.Clear();
            stringTree.clearList();
            TreeNode<string> root = stringTree.returnRoot();
            stringTree.postOrder(root);
            List<TreeNode<string>> list = stringTree.getList();
            foreach (TreeNode<string> node in list)
            {
                orderedTreeBox.Items.Add(node.data);
            }
        }

        private void stringBox_Leave(object sender, EventArgs e)
        {
            if(stringBox.Text == "")
            {
                stringBox.Text = " ";
            }
        }

       

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (treeInput.Text != "")
            {
                TreeNode<string> found = stringTree.find(treeInput.Text);
                if (found != null)
                {
                    treeBox.SelectedItem = found.data.ToString();
                }
                else
                {
                    treeSearchLabel.Text = "no results";
                }
                treeInput.Clear();
            }
        }

        private void refreshTree()
        {
            treeBox.Items.Clear();
            stringTree.clearList();
            TreeNode<string> root = stringTree.returnRoot();
            stringTree.getNodes(root);
            List<TreeNode<string>> list = stringTree.getList();
            foreach (TreeNode<string> node in list)
            {
                treeBox.Items.Add(node.data);
            }
        }



        #endregion

        // form actions for lists

        // linkedlist
        #region LinkedList
        private void lListInsert_Click(object sender, EventArgs e)
        {
            string t = lListInput.Text;
            if (t != "")
            {
                linkList.Insert(t);
                refreshLinkList();
                lListInput.Clear();
            }
        }

        private void lListFirst_Click(object sender, EventArgs e)
        {
            Node<string> t = linkList.GetFirst();
            if (t != null)
            {
                linkedList.SelectedItem = t.Element;
            }
        }

        private void lListLast_Click(object sender, EventArgs e)
        {
            Node<string> t = linkList.FindLast();
            if (t != null)
            {
                linkedList.SelectedItem = t.Element;
            }
        }

        private void lListNext_Click(object sender, EventArgs e)
        {

            if (linkedList.SelectedItem != null)
            {
                string temp = linkedList.SelectedItem.ToString();
                Node<string> t = linkList.Find(temp);
                if (t != null)
                {
                    if (t.nextNode != null)
                    {
                        linkedList.SelectedItem = t.nextNode.Element;
                    }
                }
            }
        }

        private void lListSearch_Click(object sender, EventArgs e)
        {
            string t = lListInput.Text;
            if (t != "")
            {
                Node<string> temp = linkList.Find(t);
                linkedList.SelectedItem = temp.Element;
            }
        }

        private void lListAddRange_Click(object sender, EventArgs e)
        {
            linkList.Insert("32");
            linkList.Insert("45");
            linkList.Insert("75");
            linkList.Insert("234");
            linkList.Insert("67");
            linkList.Insert("34");
            linkList.Insert("435");
            linkList.Insert("57");
            linkList.Insert("213");
            linkList.Insert("54");
            refreshLinkList();
        }


        private void refreshLinkList()
        {
            linkedList.Items.Clear();
            Node<string> temp = linkList.GetFirst();
            if (temp.Element != null)
            {
                linkedList.Items.Add(temp.Element);
                while (temp.nextNode != null)
                {
                    temp = temp.nextNode;
                    linkedList.Items.Add(temp.Element);
                }
            }
        }

        private void lListDelButton_Click(object sender, EventArgs e)
        {
            string t = lListInput.Text;
            if (t != "")
            {
                linkList.Remove(t);
                refreshLinkList();
                lListInput.Clear();
            }
        }
        #endregion

        // doublyLinkedList
        #region DoubleLinkedList
        private void dListDel_Click(object sender, EventArgs e)
        {
            string t = dListInput.Text;
            if (t != "")
            {
                dLinkList.Remove(t);
                refreshDLinkList();
                dListInput.Clear();
            }
        }

        private void dListInsertAfter_Click(object sender, EventArgs e)
        {
            string t = dListInput.Text;
            if (t != "")
            {
                if (dLinkedList.SelectedItem != null)
                {
                    Node<string> temp = dLinkList.Find(dLinkedList.SelectedItem.ToString());
                    dLinkList.Insert(t, temp.Element);
                    refreshDLinkList();
                    dListInput.Clear();
                }
            }
        }

        private void dListAddRange_Click(object sender, EventArgs e)
        {
            Node<string> temp = dLinkList.FindLast();
            dLinkList.Insert("32", temp.Element);
            dLinkList.Insert("45", "32");
            dLinkList.Insert("75", "45");
            dLinkList.Insert("234", "75");
            dLinkList.Insert("67", "234");
            dLinkList.Insert("34", "67");
            dLinkList.Insert("435", "34");
            dLinkList.Insert("57", "435");
            dLinkList.Insert("213", "57");
            dLinkList.Insert("54", "213");
            refreshDLinkList();
        }

        private void dListSearch_Click(object sender, EventArgs e)
        {
            string t = dListInput.Text;
            if (t != "")
            {
                Node<string> temp = dLinkList.Find(t);
                dLinkedList.SelectedItem = temp.Element;
            }
        }

        private void dListfirst_Click(object sender, EventArgs e)
        {
            Node<string> t = dLinkList.GetFirst();
            if (t != null)
            {
                dLinkedList.SelectedItem = t.Element;
            }
        }

        private void dListLast_Click(object sender, EventArgs e)
        {
            Node<string> t = dLinkList.FindLast();
            if (t != null)
            {
                dLinkedList.SelectedItem = t.Element;
            }
        }

        private void dListPrev_Click(object sender, EventArgs e)
        {
            if (dLinkedList.SelectedItem != null)
            {
                string temp = dLinkedList.SelectedItem.ToString();
                Node<string> t = dLinkList.Find(temp);
                if (t != null)
                {
                    if (t.previousNode != null)
                    {
                        dLinkedList.SelectedItem = t.previousNode.Element;
                    }
                }
            }
        }

        private void dListNext_Click(object sender, EventArgs e)
        {
            if (dLinkedList.SelectedItem != null)
            {
                string temp = dLinkedList.SelectedItem.ToString();
                Node<string> t = dLinkList.Find(temp);
                if (t != null)
                {
                    if (t.nextNode != null)
                    {
                        dLinkedList.SelectedItem = t.nextNode.Element;
                    }
                }
            }
        }

      

        private void dListInsert_Click(object sender, EventArgs e)
        {
            string t = dListInput.Text;
            if (t != "")
            {
                Node<string> temp = dLinkList.FindLast();
                dLinkList.Insert(t, temp.Element);
                refreshDLinkList();
                dListInput.Clear();
            }
        }

        private void refreshDLinkList()
        {
            dLinkedList.Items.Clear();
            Node<string> temp = dLinkList.GetFirst();
            if (temp.Element != null)
            {
                dLinkedList.Items.Add(temp.Element);
                while (temp.nextNode != null)
                {
                    temp = temp.nextNode;
                    dLinkedList.Items.Add(temp.Element);
                }
            }
        }


        #endregion

        // CirculairLinkedList
        #region CircularLinkedList
        private void cListInsert_Click(object sender, EventArgs e)
        {
            string t = cListInput.Text;
            if (t != "")
            {
                Node<string> temp = cLinkList.FindLast();
                cLinkList.Insert(t, temp.Element);
                refreshCLinkList();
                cListInput.Clear();
            }
        }

        private void refreshCLinkList()
        {
            cLinkedList.Items.Clear();
            Node<string> temp = cLinkList.GetFirst();
            if (temp.Element != null)
            {
                cLinkedList.Items.Add(temp.Element);
                while (temp.nextNode.Element != null)
                {
                    temp = temp.nextNode;
                    cLinkedList.Items.Add(temp.Element);
                }
            }
        }

        private void cListAddRange_Click(object sender, EventArgs e)
        {
            Node<string> temp = cLinkList.FindLast();
            cLinkList.Insert("32", temp.Element);
            cLinkList.Insert("45", "32");
            cLinkList.Insert("75", "45");
            cLinkList.Insert("234", "75");
            cLinkList.Insert("67", "234");
            cLinkList.Insert("34", "67");
            cLinkList.Insert("435", "34");
            cLinkList.Insert("57", "435");
            cLinkList.Insert("213", "57");
            cLinkList.Insert("54", "213");
            refreshCLinkList();
        }

        private void cListInsertAfter_Click(object sender, EventArgs e)
        {
            string t = cListInput.Text;
            if (t != "")
            {
                if (cLinkedList.SelectedItem != null)
                {
                    Node<string> temp = cLinkList.Find(cLinkedList.SelectedItem.ToString());
                    cLinkList.Insert(t, temp.Element);
                    refreshCLinkList();
                    cListInput.Clear();
                }
            }
        }

        private void cListFirst_Click(object sender, EventArgs e)
        {
            Node<string> t = cLinkList.GetFirst();
            if (t != null)
            {
                cLinkedList.SelectedItem = t.Element;
            }
        }

        private void cListLast_Click(object sender, EventArgs e)
        {
            Node<string> t = cLinkList.FindLast();
            if (t != null)
            {
                cLinkedList.SelectedItem = t.Element;
            }
        }

        private void cListPrev_Click(object sender, EventArgs e)
        {
            if (cLinkedList.SelectedItem != null)
            {
                string temp = cLinkedList.SelectedItem.ToString();
                Node<string> t = cLinkList.Find(temp);
                if (t != null)
                {
                    if (t.previousNode != null)
                    {
                        cLinkedList.SelectedItem = t.previousNode.Element;
                    }
                }
            }
        }

        private void cListNext_Click(object sender, EventArgs e)
        {
            if (cLinkedList.SelectedItem != null)
            {
                string temp = cLinkedList.SelectedItem.ToString();
                Node<string> t = cLinkList.Find(temp);
                if (t != null)
                {
                    if (t.nextNode.Element != null)
                    {
                        cLinkedList.SelectedItem = t.nextNode.Element;
                    }
                    else
                    {
                        // skip header
                        t.nextNode = t.nextNode.nextNode;
                        cLinkedList.SelectedItem = t.nextNode.Element;
                    }
                }
            }
        }

        private void cListDelete_Click(object sender, EventArgs e)
        {
            string t = cListInput.Text;
            if (t != "")
            {
                cLinkList.Remove(t);
                refreshCLinkList();
                cListInput.Clear();
            }
        }

        private void cListSearch_Click(object sender, EventArgs e)
        {
            string t = cListInput.Text;
            if (t != "")
            {
                Node<string> temp = cLinkList.Find(t);
                cLinkedList.SelectedItem = temp.Element;
            }
        }



        #endregion

        // form actions for iterator 
        #region Iterator
        public void fillIterList()
        {
            iterList.Insert("32");
            iterList.Insert("45");
            iterList.Insert("75");
            iterList.Insert("234");
            iterList.Insert("67");
            iterList.Insert("34");
            iterList.Insert("435");
            iterList.Insert("57");
            iterList.Insert("213");
            iterList.Insert("54");
            iterator = new ListIter<string>(iterList);

        }

        private void nextIter_Click(object sender, EventArgs e)
        {
            iterator.NextLink();
            Node<string> temp = iterator.GetCurrent();
            if (temp != null)
            {
                listIter.SelectedItem = temp.Element;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            iterator.reset();
            Node<string> temp = iterator.GetCurrent();
            if (temp != null)
            {
                listIter.SelectedItem = temp.Element;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Node<string> temp = iterator.GetCurrent();
            if (temp != null)
            {
                currentLabel.Text = temp.Element;
            }
        }

        private void iterRemove_Click(object sender, EventArgs e)
        {
            iterator.remove();
            refreshIterBox();
            Node<string> temp = iterator.GetCurrent();
            if (temp != null)
            {
                listIter.SelectedItem = temp.Element;
            }
        }

        private void iterBefore_Click(object sender, EventArgs e)
        {
            string s = iterInput.Text;
            if (s != "")
            {
                iterator.InsertBefore(s);
                refreshIterBox();
                Node<string> temp = iterator.GetCurrent();
                if (temp != null)
                {
                    listIter.SelectedItem = temp.Element;
                }
            }
        }

        private void iterAfter_Click(object sender, EventArgs e)
        {
            string s = iterInput.Text;
            if (s != "")
            {
                iterator.InsertAfter(s);
                refreshIterBox();
                Node<string> temp = iterator.GetCurrent();
                if (temp != null)
                {
                    listIter.SelectedItem = temp.Element;
                }
            }
        }

        private void refreshIterBox()
        {
            listIter.Items.Clear();
            Node<string> temp = iterator.theList.GetFirst();

            if (temp.Element != null)
            {
                listIter.Items.Add(temp.Element);
                while (temp.nextNode != null)
                {
                    temp = temp.nextNode;
                    listIter.Items.Add(temp.Element);
                }
            }
        }

        private void addList_Click(object sender, EventArgs e)
        {
            refreshIterBox();
            Node<string> temp = iterator.GetCurrent();
            if (temp != null)
            {
                listIter.SelectedItem = temp.Element;
            }
        }

        #endregion

        // form actions for hash

    }
}
