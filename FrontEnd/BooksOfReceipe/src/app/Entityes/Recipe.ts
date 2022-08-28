import { TagClass } from "./TagClass";
import {IngridientClass} from "./IngridientClass";
import { StepClass } from "./StepClass";

export class Recipe {
    id: number = 0;
    title: string = "";
    text: string = "";
    imagePath: string = "";
    likeCount: number = 0;
    timer: number = 0;
    persons: number = 0;
    tags: TagClass [] = [
        {
            text : ""
        }];
    ingridients: IngridientClass[] = [
        {
            text: "",
            count: 0,
            typeOfCount: "",
        }
    ];
    step: StepClass[] = [
        {
            count: 0,
            description: "",
        }
    ]
    }