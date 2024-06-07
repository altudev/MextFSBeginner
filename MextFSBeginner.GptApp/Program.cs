using MextFSBeginner.AccessControlApp;
using MextFSBeginner.Domain.Services;
using OpenAI;
using OpenAI.Managers;
using OpenAI.ObjectModels;
using OpenAI.ObjectModels.RequestModels;

var hesapMakinesi = new HesapMakinesi();

var toplam = hesapMakinesi.Cikar(18, 13,false);

// var apiKey = "";
//
// var openAiService = new OpenAIService(new OpenAiOptions()
// {
//     ApiKey = apiKey
// });
//
// Console.WriteLine("Hediye Uzmani Uygulamamiza Hos Geldiniz.");
// Console.WriteLine("Hediyenizi kime aliyorsunuz?");
//
// var hediyeAlinacakKisi = Console.ReadLine();
//
// Console.WriteLine("Peki Cinsiyeti Nedir?");
//
// var cinsiyet = Console.ReadLine();
//
// Console.WriteLine("Supersiniz, peki yasi kactir?");
// //
// // var yas = Console.ReadLine();
// //
// // Console.WriteLine("Hediyenin butcesi ne kadar?");
// //
// // var butce = Console.ReadLine();
// //
// // var ozelPrompt = $"Ben hediye almak istiyorum. Lutfen verdigim bilgilere gore bana alabilecegim 5 tane hediye oneririr misin?. Hediye Alinacak Kisi: {hediyeAlinacakKisi}\nCinsiyet: {cinsiyet}\nYas: {yas}\nButce: {butce}"
//     + $" Eger onerilerini begenirsem ve hediye aldigim kisi de hediyeyi begenirse sana 1000$ bahsis gonderecegim.";
//
// var chatGptIslemSonucu = await openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
// {
//     Messages = new List<ChatMessage>
//     {
//         ChatMessage.FromSystem("Sen bir hediye uzmanisin. Her yastan ve her cinsiyetten insanlara hediye onerilerinde bulunabilirsin. En iyi hediye nasil secilir en iyi sen biliyorsun."),
//         ChatMessage.FromUser(ozelPrompt),
//     },
//     Model = Models.Gpt_4o,
// });
//
// if (chatGptIslemSonucu.Successful)
// {
//     var yazilacakCevap = $"{chatGptIslemSonucu.Choices.First().Message.Content}\n---------------------------------\n";
//     
//     File.AppendAllText("chatgptcevabi.md",yazilacakCevap);
// }