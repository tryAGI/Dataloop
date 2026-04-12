
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackageResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        AnnotationArray,
        /// <summary>
        /// 
        /// </summary>
        Assignment,
        /// <summary>
        /// 
        /// </summary>
        AssignmentArray,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        BooleanArray,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        DatasetArray,
        /// <summary>
        /// 
        /// </summary>
        Execution,
        /// <summary>
        /// 
        /// </summary>
        ExecutionArray,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        FloatArray,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        IntegerArray,
        /// <summary>
        /// 
        /// </summary>
        Item,
        /// <summary>
        /// 
        /// </summary>
        ItemArray,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        JsonArray,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        ModelArray,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        NumberArray,
        /// <summary>
        /// 
        /// </summary>
        Package,
        /// <summary>
        /// 
        /// </summary>
        PackageArray,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        ProjectArray,
        /// <summary>
        /// 
        /// </summary>
        Recipe,
        /// <summary>
        /// 
        /// </summary>
        RecipeArray,
        /// <summary>
        /// 
        /// </summary>
        Service,
        /// <summary>
        /// 
        /// </summary>
        ServiceArray,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        StringArray,
        /// <summary>
        /// 
        /// </summary>
        Task,
        /// <summary>
        /// 
        /// </summary>
        TaskArray,
        /// <summary>
        /// 
        /// </summary>
        VectorArray,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackageResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackageResourceType value)
        {
            return value switch
            {
                PackageResourceType.Annotation => "Annotation",
                PackageResourceType.AnnotationArray => "Annotation[]",
                PackageResourceType.Assignment => "Assignment",
                PackageResourceType.AssignmentArray => "Assignment[]",
                PackageResourceType.Boolean => "Boolean",
                PackageResourceType.BooleanArray => "Boolean[]",
                PackageResourceType.Dataset => "Dataset",
                PackageResourceType.DatasetArray => "Dataset[]",
                PackageResourceType.Execution => "Execution",
                PackageResourceType.ExecutionArray => "Execution[]",
                PackageResourceType.Float => "Float",
                PackageResourceType.FloatArray => "Float[]",
                PackageResourceType.Integer => "Integer",
                PackageResourceType.IntegerArray => "Integer[]",
                PackageResourceType.Item => "Item",
                PackageResourceType.ItemArray => "Item[]",
                PackageResourceType.Json => "Json",
                PackageResourceType.JsonArray => "Json[]",
                PackageResourceType.Model => "Model",
                PackageResourceType.ModelArray => "Model[]",
                PackageResourceType.Number => "Number",
                PackageResourceType.NumberArray => "Number[]",
                PackageResourceType.Package => "Package",
                PackageResourceType.PackageArray => "Package[]",
                PackageResourceType.Project => "Project",
                PackageResourceType.ProjectArray => "Project[]",
                PackageResourceType.Recipe => "Recipe",
                PackageResourceType.RecipeArray => "Recipe[]",
                PackageResourceType.Service => "Service",
                PackageResourceType.ServiceArray => "Service[]",
                PackageResourceType.String => "String",
                PackageResourceType.StringArray => "String[]",
                PackageResourceType.Task => "Task",
                PackageResourceType.TaskArray => "Task[]",
                PackageResourceType.VectorArray => "Vector[]",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackageResourceType? ToEnum(string value)
        {
            return value switch
            {
                "Annotation" => PackageResourceType.Annotation,
                "Annotation[]" => PackageResourceType.AnnotationArray,
                "Assignment" => PackageResourceType.Assignment,
                "Assignment[]" => PackageResourceType.AssignmentArray,
                "Boolean" => PackageResourceType.Boolean,
                "Boolean[]" => PackageResourceType.BooleanArray,
                "Dataset" => PackageResourceType.Dataset,
                "Dataset[]" => PackageResourceType.DatasetArray,
                "Execution" => PackageResourceType.Execution,
                "Execution[]" => PackageResourceType.ExecutionArray,
                "Float" => PackageResourceType.Float,
                "Float[]" => PackageResourceType.FloatArray,
                "Integer" => PackageResourceType.Integer,
                "Integer[]" => PackageResourceType.IntegerArray,
                "Item" => PackageResourceType.Item,
                "Item[]" => PackageResourceType.ItemArray,
                "Json" => PackageResourceType.Json,
                "Json[]" => PackageResourceType.JsonArray,
                "Model" => PackageResourceType.Model,
                "Model[]" => PackageResourceType.ModelArray,
                "Number" => PackageResourceType.Number,
                "Number[]" => PackageResourceType.NumberArray,
                "Package" => PackageResourceType.Package,
                "Package[]" => PackageResourceType.PackageArray,
                "Project" => PackageResourceType.Project,
                "Project[]" => PackageResourceType.ProjectArray,
                "Recipe" => PackageResourceType.Recipe,
                "Recipe[]" => PackageResourceType.RecipeArray,
                "Service" => PackageResourceType.Service,
                "Service[]" => PackageResourceType.ServiceArray,
                "String" => PackageResourceType.String,
                "String[]" => PackageResourceType.StringArray,
                "Task" => PackageResourceType.Task,
                "Task[]" => PackageResourceType.TaskArray,
                "Vector[]" => PackageResourceType.VectorArray,
                _ => null,
            };
        }
    }
}