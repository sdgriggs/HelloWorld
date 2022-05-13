namespace HelloWorld {
    class Program {
        static void Main(string[] args){
            System.Diagnostics.Process.Start("CMD.exe", args[0]);
        }
    }
}
