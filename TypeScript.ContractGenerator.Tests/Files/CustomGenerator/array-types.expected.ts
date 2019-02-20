
export type ArrayRootType = {
    ints?: null | number[];
    nullableInts?: null | Nullable<number>[];
    byteArray?: null | string;
    nullableByteArray?: null | Nullable<Byte>[];
    enums?: null | AnotherEnum[];
    nullableEnums?: null | Nullable<AnotherEnum>[];
    strings?: null | string[];
    customTypes?: null | AnotherCustomType[];
    stringsList?: null | string[];
    customTypesDict?: null | {
        [key in string]?: AnotherCustomType;
    };
};
export type Nullable<T> = {
    hasValue: boolean;
    value: T;
};
export type Byte = {
};
export type AnotherEnum = 'B' | 'C';
export const AnotherEnums = {
    ['B']: ('B') as AnotherEnum,
    ['C']: ('C') as AnotherEnum,
};
export type AnotherCustomType = {
    d: number;
};
