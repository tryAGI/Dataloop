
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum LoginsLogQueryOrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        Attributes,
        /// <summary>
        /// 
        /// </summary>
        CreationAttributes,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        AddHook,
        /// <summary>
        /// 
        /// </summary>
        Changed,
        /// <summary>
        /// 
        /// </summary>
        DataValues,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        Decrement,
        /// <summary>
        /// 
        /// </summary>
        Destroy,
        /// <summary>
        /// 
        /// </summary>
        Equals,
        /// <summary>
        /// 
        /// </summary>
        EqualsOneOf,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        GetDataValue,
        /// <summary>
        /// 
        /// </summary>
        HasHook,
        /// <summary>
        /// 
        /// </summary>
        HasHooks,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Increment,
        /// <summary>
        /// 
        /// </summary>
        IsNewRecord,
        /// <summary>
        /// 
        /// </summary>
        IsSoftDeleted,
        /// <summary>
        /// 
        /// </summary>
        OrgId,
        /// <summary>
        /// 
        /// </summary>
        OrgRole,
        /// <summary>
        /// 
        /// </summary>
        Previous,
        /// <summary>
        /// 
        /// </summary>
        Reload,
        /// <summary>
        /// 
        /// </summary>
        RemoveHook,
        /// <summary>
        /// 
        /// </summary>
        Restore,
        /// <summary>
        /// 
        /// </summary>
        Save,
        /// <summary>
        /// 
        /// </summary>
        Sequelize,
        /// <summary>
        /// 
        /// </summary>
        Set,
        /// <summary>
        /// 
        /// </summary>
        SetAttributes,
        /// <summary>
        /// 
        /// </summary>
        SetDataValue,
        /// <summary>
        /// 
        /// </summary>
        ToJSON,
        /// <summary>
        /// 
        /// </summary>
        Update,
        /// <summary>
        /// 
        /// </summary>
        UserAgent,
        /// <summary>
        /// 
        /// </summary>
        UserId,
        /// <summary>
        /// 
        /// </summary>
        Validate,
        /// <summary>
        /// 
        /// </summary>
        Where,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoginsLogQueryOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoginsLogQueryOrderBy value)
        {
            return value switch
            {
                LoginsLogQueryOrderBy.Attributes => "_attributes",
                LoginsLogQueryOrderBy.CreationAttributes => "_creationAttributes",
                LoginsLogQueryOrderBy.Model => "_model",
                LoginsLogQueryOrderBy.AddHook => "addHook",
                LoginsLogQueryOrderBy.Changed => "changed",
                LoginsLogQueryOrderBy.DataValues => "dataValues",
                LoginsLogQueryOrderBy.Date => "date",
                LoginsLogQueryOrderBy.Decrement => "decrement",
                LoginsLogQueryOrderBy.Destroy => "destroy",
                LoginsLogQueryOrderBy.Equals => "equals",
                LoginsLogQueryOrderBy.EqualsOneOf => "equalsOneOf",
                LoginsLogQueryOrderBy.Get => "get",
                LoginsLogQueryOrderBy.GetDataValue => "getDataValue",
                LoginsLogQueryOrderBy.HasHook => "hasHook",
                LoginsLogQueryOrderBy.HasHooks => "hasHooks",
                LoginsLogQueryOrderBy.Id => "id",
                LoginsLogQueryOrderBy.Increment => "increment",
                LoginsLogQueryOrderBy.IsNewRecord => "isNewRecord",
                LoginsLogQueryOrderBy.IsSoftDeleted => "isSoftDeleted",
                LoginsLogQueryOrderBy.OrgId => "orgId",
                LoginsLogQueryOrderBy.OrgRole => "orgRole",
                LoginsLogQueryOrderBy.Previous => "previous",
                LoginsLogQueryOrderBy.Reload => "reload",
                LoginsLogQueryOrderBy.RemoveHook => "removeHook",
                LoginsLogQueryOrderBy.Restore => "restore",
                LoginsLogQueryOrderBy.Save => "save",
                LoginsLogQueryOrderBy.Sequelize => "sequelize",
                LoginsLogQueryOrderBy.Set => "set",
                LoginsLogQueryOrderBy.SetAttributes => "setAttributes",
                LoginsLogQueryOrderBy.SetDataValue => "setDataValue",
                LoginsLogQueryOrderBy.ToJSON => "toJSON",
                LoginsLogQueryOrderBy.Update => "update",
                LoginsLogQueryOrderBy.UserAgent => "userAgent",
                LoginsLogQueryOrderBy.UserId => "userId",
                LoginsLogQueryOrderBy.Validate => "validate",
                LoginsLogQueryOrderBy.Where => "where",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoginsLogQueryOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "_attributes" => LoginsLogQueryOrderBy.Attributes,
                "_creationAttributes" => LoginsLogQueryOrderBy.CreationAttributes,
                "_model" => LoginsLogQueryOrderBy.Model,
                "addHook" => LoginsLogQueryOrderBy.AddHook,
                "changed" => LoginsLogQueryOrderBy.Changed,
                "dataValues" => LoginsLogQueryOrderBy.DataValues,
                "date" => LoginsLogQueryOrderBy.Date,
                "decrement" => LoginsLogQueryOrderBy.Decrement,
                "destroy" => LoginsLogQueryOrderBy.Destroy,
                "equals" => LoginsLogQueryOrderBy.Equals,
                "equalsOneOf" => LoginsLogQueryOrderBy.EqualsOneOf,
                "get" => LoginsLogQueryOrderBy.Get,
                "getDataValue" => LoginsLogQueryOrderBy.GetDataValue,
                "hasHook" => LoginsLogQueryOrderBy.HasHook,
                "hasHooks" => LoginsLogQueryOrderBy.HasHooks,
                "id" => LoginsLogQueryOrderBy.Id,
                "increment" => LoginsLogQueryOrderBy.Increment,
                "isNewRecord" => LoginsLogQueryOrderBy.IsNewRecord,
                "isSoftDeleted" => LoginsLogQueryOrderBy.IsSoftDeleted,
                "orgId" => LoginsLogQueryOrderBy.OrgId,
                "orgRole" => LoginsLogQueryOrderBy.OrgRole,
                "previous" => LoginsLogQueryOrderBy.Previous,
                "reload" => LoginsLogQueryOrderBy.Reload,
                "removeHook" => LoginsLogQueryOrderBy.RemoveHook,
                "restore" => LoginsLogQueryOrderBy.Restore,
                "save" => LoginsLogQueryOrderBy.Save,
                "sequelize" => LoginsLogQueryOrderBy.Sequelize,
                "set" => LoginsLogQueryOrderBy.Set,
                "setAttributes" => LoginsLogQueryOrderBy.SetAttributes,
                "setDataValue" => LoginsLogQueryOrderBy.SetDataValue,
                "toJSON" => LoginsLogQueryOrderBy.ToJSON,
                "update" => LoginsLogQueryOrderBy.Update,
                "userAgent" => LoginsLogQueryOrderBy.UserAgent,
                "userId" => LoginsLogQueryOrderBy.UserId,
                "validate" => LoginsLogQueryOrderBy.Validate,
                "where" => LoginsLogQueryOrderBy.Where,
                _ => null,
            };
        }
    }
}