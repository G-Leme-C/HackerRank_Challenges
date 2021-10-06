namespace HackerRank
{
    public class TimeConversion
    {
        private string _rawInputTime;
        private string _middayMarker;
        private string[] _timeParts;

        private const string AM = "AM";
        private const string PM = "PM";

        public TimeConversion(string inputTime)
        {
            SetRawInputTime(inputTime);
        }

        private void SetRawInputTime(string inputTime) {
            _rawInputTime = inputTime;
        }

        public string ConvertToMilitaryTime() {
            GetMiddayMarker();
            GetTimeParts();            

            if(IsPmTime()) 
                ConvertPmHoursToMilitary();
            else if(IsAmTime())
                ConvertAmHoursToMilitary();
                
            return FormatOutputTime();
        }

        private bool IsPmTime() {
            return _middayMarker.Equals(PM);
        }

        private void ConvertPmHoursToMilitary() {
            if(int.TryParse(_timeParts[0], out int hours)) 
                if(hours < 12)
                    _timeParts[0] = (hours + 12).ToString("00");
        }

        private void ConvertAmHoursToMilitary() {
            if(int.TryParse(_timeParts[0], out int hours)) 
                if(hours == 12)
                    _timeParts[0] = (hours - 12).ToString("00");
        }

        private bool IsAmTime() {
            return _middayMarker.Equals(AM);
        }
        private void GetMiddayMarker() {
            _middayMarker = _rawInputTime.Substring(_rawInputTime.Length - 2, 2);
        }

        private void GetTimeParts() {
            var rawTime = _rawInputTime.Remove(_rawInputTime.Length - 2, 2);
            _timeParts = rawTime.Split(":");
        }

        private string FormatOutputTime() {
            return string.Join(':', _timeParts);
        }


    }
}