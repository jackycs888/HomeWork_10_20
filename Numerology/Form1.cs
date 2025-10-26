namespace Numerology
{
    public partial class Form1 : Form
    {
        private Dictionary<(string zodiac, int lifeNumber), string>
            _zodiacData = new();

        public Form1()
        {
            InitializeComponent();
            DataLoader(filePath);
        }

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "star.csv");

        private void DataLoader(string filePath)
        {
            
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("找不到檔案 ! ");
                    return;
                }
                using (var reader = new StreamReader(filePath))
                {
                    string header = reader.ReadLine(); // 跳過表頭

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var parts = line.Split(',');
                        if (parts.Length < 3) continue;

                        string zodiac = parts[0].Trim();
                        if (!int.TryParse(parts[1], out int lifeNum)) continue;
                        string feature = string.Join(",", parts.Skip(2));

                        _zodiacData[(zodiac, lifeNum)] = feature;
                    }
                }

            }
            catch
            {
                MessageBox.Show("讀取csv失敗 !");
            }


        }
        private string GetZodiac(DateTime date)
        {
            string[] zodiacs =
                {
                    "Capricorn摩羯座", "Aquarius水瓶座", "Pisces雙魚座", "Aries牡羊座",
                    "Taurus金牛座", "Gemini雙子座", "Cancer巨蟹座", "Leo獅子座",
                    "Virgo處女座", "Libra天秤座", "Scorpio天蠍座", "Sagittarius射手座", "Capricorn摩羯座"
                };

            int[] zodiacStartDays = { 20, 19, 21, 21, 21, 22, 23, 23, 23, 24, 23, 22 };
            int month = date.Month;
            int day = date.Day;

            if ((day < zodiacStartDays[month - 1]))
            {
                return zodiacs[month - 1];
            }
            else
            {
                return zodiacs[month];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime selectDate = dateTimePicker1.Value;

            string zodiac = GetZodiac(selectDate);

            int number = int.Parse(selectDate.ToString("yyyyMMdd"));

            int LifeNumber = SumDigitsRecursive(number);

            if(_zodiacData.TryGetValue((zodiac, LifeNumber), out string meaning))
            {
                label4.Text = zodiac;
                label6.Text = $"{LifeNumber}\n" + $"{meaning}";
            }
            else
            {
                MessageBox.Show("找不到資料");
            }
        }

        private int SumDigitsRecursive(int num)
        {
            int sum = 0;
            foreach (char c in num.ToString())
            {
                sum += c - '0';
            }
            if (sum > 9)
            {
                return SumDigitsRecursive(sum);
            }
            else
            {
                return sum;
            }
        }

    }
}
