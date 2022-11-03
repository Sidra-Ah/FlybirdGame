using UnityEngine;
using UnityEngine.UI;
using Firebase;
// using Firebase.Unity.Editor;
using Firebase.Database;

public class Database : MonoBehaviour
{
    // public string database_url = "";
    public InputField Username;
    // [SerializeField]
    public InputField Email;
    public InputField Password;
    private string userID;
    private DatabaseReference dbReference;
    // GameObject obj;
    // User user = new User();
    // User user = obj.AddComponent<User>();
    // Start is called before the first frame update
    void Start()
    {
        userID = SystemInfo.deviceUniqueIdentifier;
       // FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://console.firebase.google.com/project/fly-bird-cedff/database/fly-bird-cedff-default-rtdb/data/~2F");
        dbReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

public void CreateUser()
{
    User newUser = new User(Username.text, Email.text, Password.text);
    string json = JsonUtility.ToJson(newUser);
   
   dbReference.Child("users").Child(userID).SetRawJsonValueAsync(json);
}

    // public void savedata_firebase()
    // {
    //     user.username = Username.text;
    //     user.email = Email.text;
    //     user.password = Password.text;
    //     RestClient.Post(database_url+"/"+Username.text+".json",user);
    // }

   
}
