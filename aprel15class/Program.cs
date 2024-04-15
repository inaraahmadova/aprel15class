namespace aprel15class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();
            //test.Arr[0] = 1;
            //for (int i = 0; i < test.Arr.Length; i++)
            //{
            //    Console.WriteLine(test.Arr[i]);
            //}

            
            foreach (var item in typeof(Test).GetProperties())
            {
                Console.WriteLine(item.Name);
            }


        }
        class Test
        {
            public int[] Arr { get; set; }
            public int this[int i]
            {
                get
                {
                    return Arr[i];
                }
                set
                {
                    if (value<0)
                        throw new ArgumentException("deyer 0-dan kicik ola bilmez");
                    if (i>=Arr.Length) 
                        throw new IndexOutOfRangeException();
                }
            }
            public Test() 
            {
                Arr = new int[10];
            }
        }
    }
}
