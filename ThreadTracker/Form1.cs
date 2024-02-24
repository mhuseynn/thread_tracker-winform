namespace ThreadTracker
{
    public partial class Form1 : Form
    {
        public Thread Thread1 { get; set; }
        public Semaphore Semaphore { get; set; }

        public List<Thread> threads { get; set; }
        public int count { get; set; }

        public Form1()
        {
            InitializeComponent();
            threads = new List<Thread>();
            count = 3;
            Semaphore = new Semaphore(3, 3, "semaphore");

        }

        //Dispatcher ucun  funksiya winformda hazir yoxdur
        private void UpdateUI(Thread thread, Action updateAction)
        {

            updateAction.Invoke();

        }
        //========================================================

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                var th = Thread.CurrentThread;

                UpdateUI(th, () =>
                {
                    foreach (ListViewItem listViewItem in createdlist!.SelectedItems)
                    {
                        if (th.Name == listViewItem.Text)
                        {
                            createdlist.Items.Remove(listViewItem);
                            break;
                        }
                    }
                    waitinglist.Items.Add(th.Name);
                });

                Semaphore.WaitOne();

                UpdateUI(th, () =>
                {
                    foreach (ListViewItem listViewItem in waitinglist!.Items)
                    {
                        if (th.Name == listViewItem.Text)
                        {
                            waitinglist.Items.Remove(listViewItem);
                            break;
                        }
                    }
                    workinglist.Items.Add(th.Name);
                });

                Thread.Sleep(5000);

                Semaphore.Release();

                UpdateUI(th, () =>
                {
                    foreach (ListViewItem listViewItem in workinglist!.Items)
                    {
                        if (th.Name == listViewItem.Text)
                        {
                            workinglist.Items.Remove(listViewItem);
                            if (workinglist.Items.Count == 0)
                                counter.Enabled = true;
                            break;
                        }
                    }
                });


            });

            thread.Name = "Thread" + thread.ManagedThreadId;
            thread.IsBackground = true;
            createdlist.Items.Add(thread.Name);
            threads.Add(thread);



        }

        private void createdlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView list = (sender as ListView);

            foreach (var item in threads)
            {
                foreach (ListViewItem listViewItem in list!.SelectedItems)
                {
                    if (item.Name == listViewItem.Text)
                    {
                        item.Start();
                        break;
                    }
                }
            }
        }

        private void counter_ValueChanged(object sender, EventArgs e)
        {
            if (workinglist.Items.Count == 0)
            {
                Semaphore.Dispose();
                count = (int)counter.Value;
                Semaphore = new Semaphore((int)counter.Value, (int)counter.Value, "Semaphore");
            }
            else
            {
                counter.Value = count;
                counter.Enabled = false;
            }

        }
    }
}
