[Serializable]

class UserData
{
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set;}
    public string Age { get; set; }
    public DateTime DateOfCreation { get; set; }
    public DateTime DateOfModification { get; set; }
    public int UserCount { get; set; }


    public UserData()
    {
        UserCount = 0;
    }

}