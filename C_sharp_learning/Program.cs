namespace C_sharp_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Étant donné un tableau d'entiers "nums" et un entier "target", renvoyer les indices des deux nombres tels que leur somme soit égale à "target".
            //Vous pouvez supposer que chaque entrée a exactement une solution, et vous ne pouvez pas utiliser deux fois le même élément (indice).
            
            int[] nums1 = {2,8,1,7};
            int target1 = 9;

            int[] nums2 = { 3, 4, 2 };
            int target2 = 6;

            int[] nums3 = { 3, 3 };
            int target3 = 6;
            
            Solution solution1 = new Solution();
            int[] result1 = solution1.TwoSum(nums1, target1);
            foreach(var item in result1)
            {
                if (item == result1[0])
                {
                    Console.WriteLine("Résultat 1 : indice " + item.ToString());
                }
                else
                {
                    Console.WriteLine("et indice " + item.ToString());
                }
            }
            
            Solution solution2 = new Solution();
            int[] result2 = solution2.TwoSum(nums2, target2);
            foreach(var item in result2)
            {
                Console.WriteLine("Résultat 2 : " + item.ToString());
            }
            
            Solution solution3 = new Solution();
            int[] result3 = solution3.TwoSum(nums3, target3);
            foreach(var item in result3)
            {
                Console.WriteLine("Résultat 3 : " + item.ToString());
            }

        }
    }
}