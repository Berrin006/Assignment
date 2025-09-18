namespace Infrastracture0918.Models;

public class ProductResult
{
    public bool Succeded { get; set; }

    public string?  Error { get; set; }
}

public class ProductResukt<T> : ProductResult
{
    public T? Content { get; set; }
}
