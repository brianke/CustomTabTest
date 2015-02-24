using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CustomTabTest.Models
{
    public class TaskCollection : ObservableCollection<UtilitiesTask>
    {
        public override int GetHashCode()
        {
            int hashCode = 0;
            foreach (var item in Items)
            {
                if (item != null)
                {
                    // Aggregate item hash codes
                    hashCode = hashCode ^ item.GetHashCode(); 
                }
            }
            return hashCode;
        }
    }
}
