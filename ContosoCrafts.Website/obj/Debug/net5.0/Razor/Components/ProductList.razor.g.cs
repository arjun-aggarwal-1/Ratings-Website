#pragma checksum "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69b83b5a2c6bf3ee2e31b00a198b5971f7f6ee36"
// <auto-generated/>
#pragma warning disable 1591
namespace ContosoCrafts.Website.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
using ContosoCrafts.Website.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
using ContosoCrafts.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
#nullable restore
#line 9 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddAttribute(4, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                                    (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "data-toggle", "modal");
            __builder.AddAttribute(6, "data-target", "#productModal");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 13 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenElement(13, "h5");
            __builder.AddAttribute(14, "class", "card-title");
#nullable restore
#line 15 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
__builder.AddContent(15, product.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                    
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
#nullable restore
#line 34 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "modal fade");
            __builder.AddAttribute(19, "id", "productModal");
            __builder.AddAttribute(20, "tabindex", "-1");
            __builder.AddAttribute(21, "role", "dialog");
            __builder.AddAttribute(22, "aria-labelledby", "productTitle");
            __builder.AddAttribute(23, "aria-hidden", "true");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(26, "role", "document");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-content");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-header");
            __builder.OpenElement(31, "h5");
            __builder.AddAttribute(32, "class", "modal-title");
            __builder.AddAttribute(33, "id", "productTitle");
#nullable restore
#line 40 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
__builder.AddContent(34, selectedProduct.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                    ");
            __builder.AddMarkupContent(36, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal-body");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "card");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "card-img");
            __builder.AddAttribute(44, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 47 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "card-body");
            __builder.OpenElement(48, "p");
            __builder.AddAttribute(49, "class", "card-text");
#nullable restore
#line 50 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
__builder.AddContent(50, selectedProduct.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "modal-footer");
#nullable restore
#line 56 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "<span>Be the first to vote</span>");
#nullable restore
#line 59 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "span");
#nullable restore
#line 62 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
__builder.AddContent(56, voteCount);

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, " ");
#nullable restore
#line 62 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
__builder.AddContent(58, voteLabel);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 63 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                     for (int i = 1; i < 6; i++)
                    {
                        var currentStar = i;
                        if (i <= currentRating && currentRating != 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "span");
            __builder.AddAttribute(60, "class", "fa-star fa checked");
            __builder.AddAttribute(61, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                                                                       (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 70 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "span");
            __builder.AddAttribute(63, "class", "fa-star fa");
            __builder.AddAttribute(64, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                                                               (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 74 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "/Users/arjunaggarwal/Projects/ContosoCrafts/ContosoCrafts.Website/Components/ProductList.razor"
       
    Product selectedProduct;
    string selectedProductId;

    [AuthorizeAttribute]
    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    [AuthorizeAttribute]
    void GetCurrentRating()
    {
        if (selectedProduct.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }
        System.Console.WriteLine($"Current rating for {selectedProductId} : {currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectedProductId} : {rating}");
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591