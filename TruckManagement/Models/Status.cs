namespace TruckManagement.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }

    /*  How to use this:
     *  Status inProgressStatus = new Status
        {
            StatusId = 1,
            StatusName = "In progress"
        };

        Status finishedStatus = new Status
        {
            StatusId = 2,
            StatusName = "Finished"
        };

        Status notAssignedStatus = new Status
        {
            StatusId = 3,
            StatusName = "Not Assigned"
        };
    */
}

