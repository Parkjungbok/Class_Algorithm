namespace _240118.homework
{
    public class CheetKey
    {
        private Dictionary<string, Action> cheatDic;
            
        public CheetKey()
        {
            cheatDic = new Dictionary<string, Action>();

            cheatDic.Add("show me the money", ShowMeTheMoney);
            cheatDic.Add("there is no cow level", ThereIsNoCowLevel);
        }        
        public void Run(string cheatkey)
        {
            // 조건문 없이 바로 탐색
            cheatDic.TryGetValue(cheatkey, out Action action);
            action?.Invoke();
        }
        public void ShowMeTheMoney()
        {
            Console.WriteLine("골드를 늘려주는 치트키 발동!");
        }
        public void ThereIsNoCowLevel()
        {
            Console.WriteLine("바로 승리합니다 치트키 발동!");
        }
        static void Main(string[] args)
        {


        }
    }
}