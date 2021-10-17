namespace Hotel.Model
{
    public class User
    {
        private string _fiscalcode;
        private string _name;
        private string _surname;
        private string _city;
        private string _province;
        private string _mail;
        private string _phone;
        private string _mobile;
        public User() { }
        public string FiscalCode 
        {
            get => _fiscalcode;
            set => _fiscalcode = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public string City
        {
            get => _city;
            set => _city = value;
        }
        public string Province
        {
            get => _province;
            set => _province = value;
        }
        public string Mail
        {
            get => _mail;
            set => _mail = value;
        }
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }
        public string Mobile
        {
            get => _mobile;
            set => _mobile = value;
        }
        public override string ToString()
        {
            return " USER ==> " + " FiscalCode: " + FiscalCode + " Name: " + Name + " Surname: " + Surname + " City: " + City + " Province: " + Province + " Mail: " + Mail + " Phone: " + Phone + " Mobile: " + Mobile;
        }
    }
}
