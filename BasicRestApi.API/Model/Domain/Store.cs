using System;
namespace BasicRestApi.API
{
    public class Store
    {

        public int Id { get; set; }

        public String City { get; set; }
        public String Street { get; set; }
        public String Number { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }

        public Store()
        {
        }
    }
}
