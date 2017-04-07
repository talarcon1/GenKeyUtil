using Android.App;
using Android.Widget;
using Android.OS;

namespace GenKeyUtil
{
    [Activity(Label = "@string/title", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        const short SUCCESS = 0;
        const short FAILURE = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
             Button btnStart = FindViewById<Button>(Resource.Id.btnStart);
            Button btnClear = FindViewById<Button>(Resource.Id.btnClear);
            EditText txtEntry = FindViewById<EditText>(Resource.Id.txtEntry);
             
             TextView lblSolution = FindViewById<TextView>(Resource.Id.lblSolution);
             btnStart.Click += delegate
             {
                 short lresult;
                 string solution = "";
                 lresult = EnterRoutine(txtEntry.Text, ref solution);
                 if (lresult == SUCCESS)
                 {
                     lblSolution.Text = solution;
                     txtEntry.Text = "";
                 }
                 else 
                 {
                     lblSolution.Text = "Failure";
                 }
             };

            btnClear.Click += delegate
            {
                lblSolution.Text = "";
                txtEntry.Text = "";
            };
        }

        public short EnterRoutine(string entry, ref string solution)
        {
            if (entry == "") { return FAILURE; }
            else 
            { 
               solution =  BuildKey(entry);
                return SUCCESS;
            }
           
        }

        public string BuildKey(string entry)
        {
            string key = "";
            char[] entryArray = entry.ToCharArray();
            for (int x = 0; x < entryArray.Length; x++)
            {
           
                switch (entryArray[x])
                {
                    case '0':
                        if (x < 5)
                            {
                                key += "@";
                            }
                            else
                            {
                                key += "P";
                            }
                            break;
                        case '1':
                            if (x < 5)
                            {
                                key += "A";
                            }
                            else
                            {
                                key += "Q";
                            }
                            break;
                        case '2':
                            if (x < 5)
                            {
                                key += "B";
                            }
                            else
                            {
                                key += "R";
                            }
                            break;
                        case '3':
                            if (x < 5)
                            {
                                key += "C";
                            }
                            else
                            {
                                key += "S";
                            }
                            break;
                        case '4':
                            if (x < 5)
                            {
                                key += "D";
                            }
                            else
                            {
                                key += "T";
                            }
                            break;
                        case '5':
                            if (x < 5)
                            {
                                key += "E";
                            }
                            else
                            {
                                key += "U";
                            }
                            break;
                        case '6':
                            if (x < 5)
                            {
                                key += "F";
                            }
                            else
                            {
                                key += "V";
                            }
                            break;
                        case '7':
                            if (x < 5)
                            {
                                key += "G";
                            }
                            else
                            {
                                key += "W";
                            }
                            break;
                        case '8':
                            if (x < 5)
                            {
                                key += "H";
                            }
                            else
                            {
                                key += "X";
                            }
                            break;
                        case '9':
                            if (x < 5)
                            {
                                key += "I";
                            }
                            else
                            {
                                key += "Y";
                            }
                            break;
                        default:
                           // Console.WriteLine("Default case");
                            break;
               
                }
            }
               
                
            return key;
        }

            
    }

    
}

