// command- dotnet --version
/* abstract ko object bandeina similarly interface
value type = enum(fixed), numeric type, bool, char
if fixed/pre-defined then in value type
reference type= tannai value basxa in array(dynamic)

variable is a storage location that has a modifiabke value.
It can be a local variable , parameter, field(instance or static), or array element

Stack->block of memory for storing local variables and parameters(for primitive)

Heap->reserved memory space(for non-primitive->array, objects ,...)
selective-> select vayo vane tyo choose aru sabai no use

definite assignment-> three implications
-local variablemust be assigned a value before they are read(compile-time error)
-function arguments must be supplied when a method is called(unless marked as optional)
-all other variable(such as fields or array elements) are automatically initialized by runtime
static int x; //0


default values
all ref type - null
char -'\0'
bool- false
all numeric and enum - 0
decimal d = default(d);

ref, out ->pass by ref 
ref->in coming(opposite of out)
out->outgoing bahira variable declare vitra manipulation

2081-01-10
*params modifier
->the params parameter modifier may be secified on the last parameter of a method so that the method accepts any
number of arguments of a particlar type. must be declared as an array.
int sum (params int[] ints) 

types of function-4
-input dine output dine
-input naline output din
-input naline output nadine
-input naline output dine

static -> object nabanai call garna sakinxa

-associativity
left associativity for binary operations or arithmetic operations
right associativity for assignment operator
null operator- class ko object ma null assign garna sakxa
{String -> class
string -> datatype }

-null coalescing operator- string s1 = null;
string s1= s2 ?? "nothing";by default, it checks previous value condition 
null association is with memory. memory reference that says that space is null
-null conditional operator(?.)
System .test.StringBuilder sb = null;
->string s = sb?.ToString();
no error if null, gives null: instead evaluates to null

-Statement
single line->declaration Statement
multi line

const declaration->change nahune value (static for class, const for method, variable)
-const double c = 2.768;
cannot modify the c value

-expression Statement
->single line
->value assign

-Control Statement(2081-01-11)
->control flow of the execution
-Iteration Statement

return- return values(final answer dinxa), break(iteration cancel)
throw-error throw(bichma flow break vayo vanxa)
->if return,throw, break are same i.e after these keywords nine of the statements are executed
continue-bypass(current statement or iteration execute gardeina ani continues the iteration)

logic->custom algortihm
