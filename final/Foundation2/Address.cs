public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }


}