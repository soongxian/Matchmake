namespace JodohFinder.Domain
{
    public partial class JF_PARTICIPANT
    {
        public JF_PARTICIPANT(Guid voucherId, string name, string gender, Guid ageGroupId, string contact)
        {
            VOUCHER_ID = voucherId;
            PARTICIPANT_NAME = name;
            PARTICIPANT_GENDER = gender;
            PARTICIPANT_AGEGROUP_ID = ageGroupId;
            PARTICIPANT_CONTACT = contact;
        }
    }
}
