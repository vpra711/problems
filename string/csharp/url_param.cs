class url_param
{
    public void getInput()
    {
        int input = int.Parse(Console.ReadLine() + "");

        string[] parameters = new String[input];

        int i;

        for(i = 0; i < input; i++)
        {
            parameters[i] = Console.ReadLine() + "";
        }

        getUrlHashMap("https://www.bing.com/careers?heelo=hi&param_1=hi_1", parameters);
    }

    public void getUrlHashMap(String url, String[] parameters)
    {


        Dictionary<String, String> dict = new Dictionary<String, String>();

        url = url.Substring(url.IndexOf('?') + 1);

        String[] param = url.Split('&');

        foreach(String i in param)
        {
            String[] j = i.Split('=');
            dict.Add(j[0], j[1]);
        }

        foreach(String i in parameters)
        {
            if(dict.ContainsKey(i))
            {
                Console.WriteLine(dict[i]);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}