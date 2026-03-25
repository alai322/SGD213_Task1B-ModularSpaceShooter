using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TagListType
{
    Blacklist,
    Whitelist
}

// Destroy depending on the tag of the object
public class DestroyedOnCollision : MonoBehaviour
{
    [SerializeField]
    private TagListType tagListType = TagListType.Blacklist;

    // A list of tags which we use to determine whether to explode or not
    // Depending on the tagListType (Blacklist or Whitelist)
    [SerializeField]
    private List<string> tags;

    // Detect collision
    void OnTriggerEnter2D(Collider2D other)
    {
        bool tagInList = tags.Contains(other.gameObject.tag);
        
        // Destroy if it's a Blacklist and the tag IS in the Blacklist
        if (tagListType == TagListType.Blacklist 
            && tagInList)
        {
            Destroy(gameObject);
        }
         // Destroy if it's a Whitelist and the tag is NOT in the Whitelist
        else if (tagListType == TagListType.Whitelist 
            && !tagInList)
        {
            Destroy(gameObject);
        }
    }
}
