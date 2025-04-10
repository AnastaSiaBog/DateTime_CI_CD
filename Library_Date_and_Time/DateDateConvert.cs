namespace Library_Date_and_Time
{
    public class DateDateConvert
    {

        public static int DaysBetween(DateTime dateTime1, DateTime dateTime2)
        {
            // Проверяем на равные даты. Если равны, то разница 0.
            if (dateTime1 == dateTime2)
            {
                return 0;
            }

            // Проверяем, если dateTime1 позже dateTime2
            if (dateTime1 > dateTime2)
            {
                throw new ArgumentException("dateTime1 не может быть позже dateTime2.");
            }

            // Используем свойство .Subtract, чтобы получить количество дней между датами
            TimeSpan difference = dateTime2 - dateTime1;
            return difference.Days;
        }
    }

}
