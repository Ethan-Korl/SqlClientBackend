namespace SqlClientBackend.Models.MongoDb
{
    class EamilVerificationCodes
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Code { get; set; }
    }
}