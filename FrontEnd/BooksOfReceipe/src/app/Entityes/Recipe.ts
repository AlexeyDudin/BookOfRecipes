import { TagClass } from "./TagClass";
import {IngridientClass as IngridientDto} from "./IngridientClass";
import { StepClass as StepDto } from "./StepClass";
import { User } from "./user";
import { RecipePhoto } from "./RecipePhoto";

export class RecipeDto {
    Id: number = 0;
    Title: string = "";
    Owner!: User | null;
    DescrptionText: string = "";
    Tags: TagClass [] = [];
    TimeRemaining: number = 0;
    CountPersons: number = 0;
    Ingridients: IngridientDto[] = [{Name: "", Products: ""}];
    Steps: StepDto[] = [{ Number: 1, Description: ""}];
    LikeCount: number = 0;
    RecipePhoto!: RecipePhoto;
    }