using CFAEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAServices
{
    public class CFAParseService: ICFAParseService
    {
        public CFAParseService()
        {

        }

        public int Calculator(string s)
        {
            Stack<CFAGroup> tempCollections = new Stack<CFAGroup>();
            Stack<CFAGroup> collestionhelper = new Stack<CFAGroup>();
            bool inuse = true;
            int depth = 0;
            CFAGroup temp;
            for (int i = 0; i < s.Length; i++)
            {
                if ('!' == s[i])
                    i++;
                else if ('<' == s[i])
                    inuse = false;
                else if ('>' == s[i])
                    inuse = true;
                else
                {
                    if (inuse)
                    {
                        if ('{' == s[i])
                        {
                            collestionhelper.Push(new CFAGroup(depth));
                            depth += 1;
                        }
                        else if ('}' == s[i])
                        {
                            depth -= 1;
                            temp = collestionhelper.Pop();
                            if (tempCollections.Count != 0)
                            {
                                if (temp.Depth > tempCollections.Peek().Depth)
                                {
                                    CFAGroup c = tempCollections.Pop();
                                    c.AddCollection(temp);
                                    tempCollections.Push(c);
                                }
                                else if (temp.Depth < tempCollections.Peek().Depth)
                                {
                                    while (tempCollections.Count != 0 && temp.Depth < tempCollections.Peek().Depth)
                                    {
                                        temp.AddCollection(tempCollections.Pop());
                                    }
                                    tempCollections.Push(temp);
                                }
                                else
                                    tempCollections.Push(temp);

                            }
                            else
                                tempCollections.Push(temp);

                        }
                        else//others
                            continue;
                    }
                    else// ignore
                        continue;
                }



            }

            int sum = 0;
            while(tempCollections.Count != 0)
            {
                sum += tempCollections.Pop().TotalScore;
            }
            return sum;
                
        }

    }

    public interface ICFAParseService
    {
        int Calculator(string s);
    }
}
