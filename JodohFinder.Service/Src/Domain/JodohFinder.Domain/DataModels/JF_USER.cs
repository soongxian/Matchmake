using Newtonsoft.Json;

namespace JodohFinder.Domain
{
    public partial class JF_USER
    {
        public Guid USER_ID { get; set; }
        public string USER_USERNAME { get; set; }
        public string USER_PASSWORD { get; set; }

        public Guid USER_ROLE_ID { get; set; }

        public JF_ROLE JF_ROLE { get; set; }

        [JsonIgnore]
        public ICollection<JF_VOUCHER> JF_VOUCHER { get; set; }

        public JF_USER()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }
}
