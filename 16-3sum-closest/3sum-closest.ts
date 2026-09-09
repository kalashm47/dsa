function threeSumClosest(nums: number[], target: number): number {
    const duplicates = <T>(arr: T[]): boolean => {
        return new Set(arr).size !== arr.length;
    }

    const arr = nums.length;
    let closestSum = nums[0] + nums[1] + nums[2];

    for (let i = 0; i < arr; i++) {
        for(let j = i + 1; j < arr; j++){
            for (let k = j + 1; k < arr; k++){
                const countSum = nums[i] + nums[j] + nums[k];

                if(Math.abs(countSum - target) <
                    Math.abs(closestSum - target)){
                        closestSum = countSum
                    }
                
            }
        }
    }

    return closestSum;
}