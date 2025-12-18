public class Post
{
    public string Title ;
    public string Description ;
    public int likeCount;
    public bool isPublished;

    public void Publish()
    {
        isPublished = true;
    } 
    public void Like()
    {
        likeCount++;
    }


}