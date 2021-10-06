namespace HackerRank
{
    public class TimeConversion
    {
        
        public string ConvertToMilitaryTime(string inputTime) {

            var middayMarker = inputTime.Substring(inputTime.Length - 2, 2);
            inputTime = inputTime.Remove(inputTime.Length - 2, 2);

            var timeParts = inputTime.Split(":");

            if(middayMarker.Equals("PM")) 
            {
                if(int.TryParse(timeParts[0], out int hours)) 
                    if(hours < 12)
                        timeParts[0] = (hours + 12).ToString("00");
            }
            else 
            {
                if(int.TryParse(timeParts[0], out int hours)) 
                    if(hours == 12)
                        timeParts[0] = (hours - 12).ToString("00");
            }

            return string.Join(':', timeParts);
        }


    }
}