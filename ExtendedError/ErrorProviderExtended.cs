// Following class is inherited from basic ErrorProvider class
public class ErrorProviderExtended : System.Windows.Forms.ErrorProvider
{

    private ValidationControlCollection _validationcontrols = new ValidationControlCollection();

    private string _summarymessage = "Please enter following mandatory fields,";

    public string SummaryMessage
    {
        get
        {
            return _summarymessage;
        }
        set
        {
            _summarymessage = value;
        }
    }

    public ValidationControlCollection Controls
    {
        get
        {
            return _validationcontrols;
        }
        set
        {
            _validationcontrols = value;
        }
    }

    public bool CheckAndShowSummaryErrorMessage()
    {
        if ((Controls.Count <= 0))
        {
            return true;
        }
        int i;
        string msg = (SummaryMessage + ("\r\n" + "\r\n"));
        bool berrors = false;
        for (i = 0; (i
                    <= (Controls.Count - 1)); i++)
        {
            if (Controls[i].Validate)
            {
                if (( ((System.Windows.Forms.Control)Controls[i].ControlObj).Text.Trim() == ""))
                {
                    msg+=  "=> " + Controls[i].DisplayName + "\r\n";
                    SetError((System.Windows.Forms.Control)Controls[i].ControlObj, Controls[i].ErrorMessage);
                    berrors = true;
                }
                else
                {
                    SetError((System.Windows.Forms.Control)Controls[i].ControlObj, "");
                }
            }
            else
            {
                SetError((System.Windows.Forms.Control)Controls[i].ControlObj, "");
            }
        }
        if (berrors)
        {
            System.Windows.Forms.MessageBox.Show(msg, "Missing Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
            return false;
        }
        else
        {
            return true;
        }
    }

    // Following function clears error messages from all controls.
    public void ClearAllErrorMessages()
    {
        int i;
        for (i = 0; (i
                    <= (Controls.Count - 1)); i++)
        {
            SetError((System.Windows.Forms.Control)Controls[i].ControlObj, "");
        }
    }

    // This function hooks validation event with all controls.
    public void SetErrorEvents()
    {
        int i;
        for (i = 0; i<= (Controls.Count - 1); i++)
        {
            ((System.Windows.Forms.Control)(Controls[i].ControlObj)).Validating += this.Validation_Event;
        }
    }

    // Following event is hooked for all controls, it sets an error message with the use of ErrorProvider.
    private void Validation_Event(object sender, System.ComponentModel.CancelEventArgs e)
    {
        // Handles txtCompanyName.Validating
        if (Controls[sender].Validate)
        {
            if ((((System.Windows.Forms.Control)sender).Text.Trim() == ""))
            {
                base.SetError((System.Windows.Forms.Control)sender, (Controls[sender]).ErrorMessage);
            }
            else
            {
                base.SetError((System.Windows.Forms.Control)sender, "");
            }
        }
    }
}
// Following class is inherited from CollectionBase class. It is used for holding all Validation Controls.
// This class is collection of ValidationControl class objects.
// This class is used by ErrorProviderExtended class.
public class ValidationControlCollection : System.Collections.CollectionBase
{

    public ValidationControl this[int ListIndex]
    {
        get
        {
            return (ValidationControl)this.List[ListIndex];
        }
        set
        {
            this.List[ListIndex] = value;
        }
    }

    public ValidationControl this[object pControl]
    {
        get
        {
            if ((pControl == null))
            {
                // TODO: Exit
            }
            if ((GetIndex(((System.Windows.Forms.Control)pControl).Name) < 0))
            {
                return new ValidationControl();
            }
            return (ValidationControl)this.List[GetIndex(((System.Windows.Forms.Control)pControl).Name)];
        }
        set
        {
            if ((pControl == null))
            {
                // TODO: Exit
            }
            if ((GetIndex(((System.Windows.Forms.Control)pControl).Name) < 0))
            {
                // TODO: Exit
            }
            this.List[GetIndex(((System.Windows.Forms.Control)pControl).Name)] = value;
        }
    }

    int GetIndex(string ControlName)
    {
        int i;
        for (i = 0; (i
                    <= (Count - 1)); i++)
        {
            if ((((System.Windows.Forms.Control)(this[i].ControlObj)).Name.ToUpper() == ControlName.ToUpper()))
            {
                return i;
            }
        }
        return -1;
    }

    public void Add( object pControl, string pDisplayName)
    {
        if ((pControl == null))
        {
            return;
        }
        ValidationControl obj = new ValidationControl();
        obj.ControlObj = pControl;
        obj.DisplayName = pDisplayName;
        obj.ErrorMessage = ("Please enter " + pDisplayName);
        this.List.Add(obj);
    }

    public void Add( object pControl, string pDisplayName, string pErrorMessage)
    {
        if ((pControl == null))
        {
            return;
        }
        ValidationControl obj = new ValidationControl();
        obj.ControlObj = pControl;
        obj.DisplayName = pDisplayName;
        obj.ErrorMessage = pErrorMessage;
        this.List.Add(obj);
    }

    public void Add(object pControl)
    {
        if ((pControl == null))
        {
            return;
        }
        ValidationControl obj = new ValidationControl();
        obj.ControlObj = pControl;
        obj.DisplayName = ((System.Windows.Forms.Control)pControl).Name;
        obj.ErrorMessage = ("Please enter " + ((System.Windows.Forms.Control)pControl).Name);
        this.List.Add(obj);
    }

    public void Add(ValidationControl pControl)
    {
        if ((pControl == null))
        {
            return;
        }
        this.List.Add(pControl);
    }

    public void Remove(object pControl)
    {
        if ((pControl == null))
        {
            return;
        }
        int i = this.GetIndex(((System.Windows.Forms.Control)pControl).Name);
        if ((i >= 0))
        {
            this.List.RemoveAt(i);
        }
    }
}
// ValidationControl class is used to hold any control from windows form. 
// It holds any control in ControlObj property.
public class ValidationControl
{

    private object _control;

    private string _displayname;

    private string _errormessage;

    private bool _validate = true;

    public bool Validate
    {
        get
        {
            return _validate;
        }
        set
        {
            _validate = value;
        }
    }

    public object ControlObj
    {
        get
        {
            return _control;
        }
        set
        {
            _control = value;
        }
    }

    public string DisplayName
    {
        get
        {
            return _displayname;
        }
        set
        {
            _displayname = value;
        }
    }

    public string ErrorMessage
    {
        get
        {
            return _errormessage;
        }
        set
        {
            _errormessage = value;
        }
    }
}

