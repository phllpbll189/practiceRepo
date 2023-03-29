def maximumUnits(boxTypes, truckSize):
    """
    :type boxTypes: List[List[int]]
    :type truckSize: int
    :rtype: int
    """
    return_amount = 0
    remaining_truck_space = truckSize

    while remaining_truck_space > 0:
        prev = [0, 0]

        for box in boxTypes:
            if box[1] > prev[1] and box[0] > 0:
                prev = box

        index_of_most = boxTypes.index(prev)
        available_boxes = boxTypes[index_of_most][0]
        units_per_box = boxTypes[index_of_most][1]

        if remaining_truck_space - available_boxes > 0:
            return_amount += available_boxes * units_per_box
            boxTypes[index_of_most][0] = 0
            remaining_truck_space = remaining_truck_space - available_boxes
            print(available_boxes)

        else:
            return_amount += remaining_truck_space * units_per_box
            boxTypes[index_of_most][0] = boxTypes[index_of_most][0] - remaining_truck_space
            remaining_truck_space = 0

    return return_amount
