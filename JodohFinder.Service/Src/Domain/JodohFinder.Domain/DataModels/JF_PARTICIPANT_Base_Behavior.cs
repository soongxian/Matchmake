namespace JodohFinder.Domain
{
    public partial class JF_PARTICIPANT
    {
        public JF_PARTICIPANT(string name, string gender, Guid ageGroupId, string contact, Guid voucherId)
        {
            PARTICIPANT_NAME = name;
            PARTICIPANT_GENDER = gender;
            PARTICIPANT_AGEGROUP_ID = ageGroupId;
            PARTICIPANT_CONTACT = contact;
            PARTICIPANT_VOUCHER_ID = voucherId;
        }
    }
}
