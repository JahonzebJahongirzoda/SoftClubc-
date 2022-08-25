using Models.Domain;

namespace Services.Services;

public class PostService
{
 private List<Post> namesOfPosts = new List<Post>();


 public List<Post> GetPost(){
return namesOfPosts;
 }  





public void Add(Post post){
namesOfPosts.Add(post);
}






public void Update(Post post, int id){
int cnt=0;
foreach (var st in namesOfPosts)
{
   if(st.Id==id){
    namesOfPosts.Remove(st);
    namesOfPosts.Insert(cnt,post);
   }
   cnt++;
}

}


public Post GetPostById(int id){
Post ik =new Post();
foreach (var st in namesOfPosts)
{
   if(st.Id==id)
   
ik=st;
    
}
return ik;
}






public void Delete( int id){
foreach (var st in namesOfPosts)
{
   if(st.Id==id){
    namesOfPosts.Remove(st);
   }
}

}



public int Count(){
int cnt=namesOfPosts.Count();
return cnt;

}


}