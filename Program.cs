using System; 
using System.Collections.Generic;

class MyClass {
    static void Main(string[] args) {
        /*
         * Read input from stdin and provide input before running*/
        var line1 = System.Console.ReadLine().Trim();
        var N = Int32.Parse(line1);
        string[] testCasesCount = new string[N];
        for (var i = 0; i < N; i++) {
            testCasesCount[i] = Console.ReadLine().Trim();    
        }
        for(int k=0;k<testCasesCount.Length;k++){
        	string word=testCasesCount[k];
        	Console.WriteLine("{0}",FindMagicCount(word));
        }
    }
    
    static int FindMagicCount(string word) {
            int answer = 0;
            int len=word.Length;
        
            //To find odd panildroms
            for (int i = 0; i < len;i++)
            {
                int tempLen1 = 1,j = 1;
                answer += tempLen1;
                while ((i - j) > -1 && (i + j) < len)
                {
                    if (word[i - j] == word[i + j])
                    {
                        tempLen1 += 2;
                        answer += (tempLen1 * tempLen1);
                        j++;
                    }
                    else break;
                }
            }

            //To find even panildroms
            for (int i = 0; i < len-1; i++) {
                if (word[i] == word[i+1]) {
                    int tempLen2 = 2, j = 1;
                    answer += (tempLen2 * tempLen2);
                    while ((i - j) > -1 && (i + j + 1) < len) {
                        if (word[i - j] == word[(i + 1) + j])
                        {
                            tempLen2 += 2;
                            answer += (tempLen2 * tempLen2);
                            j++;
                        }
                        else break;
                    }
                }
            }
            return answer;
        }
}
