// using SqlClientBackend.Models.MongoDb;

// namespace SqlClientBackend.Services
// {
//     public class MongoDbService
//     {
//         private readonly IMongoCollection<EamilVerificationCodes> _booksCollection;

//         public MongoDbService(
//             IOptions<MongoDbSettings> mongoDbSettings)
//         {
//             var mongoClient = new MongoClient(
//                 mongoDbSettings.Value.ConnectionString);

//             var mongoDatabase = mongoClient.GetDatabase(
//                 mongoDbSettings.Value.DatabaseName);

//             _booksCollection = mongoDatabase.GetCollection<EamilVerificationCodes>(
//                 mongoDbSettings.Value.BooksCollectionName);
//         }

//         public async Task<EamilVerificationCodes?> GetAsync(string id) =>
//             await _booksCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

//         public async Task CreateAsync(EamilVerificationCodes verCode) =>
//             await _booksCollection.InsertOneAsync(verCode);

//         public async Task UpdateAsync(string id, EamilVerificationCodes updatedBook) =>
//             await _booksCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

//         public async Task RemoveAsync(string id) =>
//             await _booksCollection.DeleteOneAsync(x => x.Id == id);
//     }
// }