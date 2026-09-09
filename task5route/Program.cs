namespace task5route
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region question 1
            // book b1 = new book();
            //b1.password;
            //// can not decleared here because private can declere in it,s scoop only can not decleared out side scoop or out project 
            //#endregion
            //#region question2 
            //book b1 = new book();
            //Console.WriteLine(b1.copiesInStock);
            //// it will print 5 because internal can be decleared in it's scoop and out side it's scoop but not out side project
            //#endregion
            //#region question3 
            //book b1 = new book();
            //b1.title = "sss";
            //Console.WriteLine(b1.title);
            //#endregion

            #region question 4
            book b1 = new book();
            b1.genre = Genre.Science;
            Console.WriteLine(b1.genre); 
            #endregion
        }
    }
}
